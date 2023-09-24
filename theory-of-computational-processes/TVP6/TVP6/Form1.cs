using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVP6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int TetradLength = 4;
        public int length;
        public byte TgP;
        public byte Ct;
        public int lengthC;
        public bool isRepeat = true;

        private void startButtonClick(object sender, EventArgs e)
        {
            HistoryBox.Text = "";
            length = numADecimalTextBox.Text[0] == '-' ? numADecimalTextBox.Text.Length - 1 : numADecimalTextBox.Text.Length;

            // Создаем объекты регистор множителей и произведения
            Register RgA = new Register(length, numADecimalTextBox.Text[0] == '-' ? (byte)1 : (byte)0);
            Register RgB = new Register(length, NumBDecimalTextBox.Text[0] == '-' ? (byte)1 : (byte)0);
            Register RgC = new Register(length*2, 0);

            // Создаем объект регистра корректировки
            CorrectedRegister RgCorrected = new CorrectedRegister(length + 1, 0);


            // Перевод числа в двоичную систему и заносим в регистры
            DecimalToBinary(RgA, numADecimalTextBox.Text[0] == '-' ? numADecimalTextBox.Text.Substring(1) : numADecimalTextBox.Text);
            DecimalToBinary(RgB, NumBDecimalTextBox.Text[0] == '-' ? NumBDecimalTextBox.Text.Substring(1) : NumBDecimalTextBox.Text);

            NumABinanaryBox.Text = RgA.BitsToString();
            NumBBinaryBox.Text = RgB.BitsToString();


            // Создаем объекты мультиплексоров
            Multiplexor mullA = new Multiplexor();
            Multiplexor mullB = new Multiplexor();

            // Создаем объект демультиплексора
            Demultiplexor Dmull = new Demultiplexor(length + 1);

            // Создаем объект сумматора
            Summator Sum = new Summator();

            // Начинаем перемножать
            lengthC = length;

            Register RgCExtended = new Register(length + 1, 0);

            while (lengthC > 0)
            {
                // Создаем объект регистра, который будет иметь на одну тетраду больше с целью удобного сложения
                Register RgAExtended = new Register(length + 1, 0);

                // Копируем значения А в увеличенный регистр
                CopyRegister(RgA, RgAExtended, 0);


                while (IsNull(RgB))
                {
                    HistoryBox.Text += $"Итерация умножения\n\n";
                    HistoryBox.Text += $"{RgCExtended.BitsToStringNoSing()}\n";
                    HistoryBox.Text += $"{RgAExtended.BitsToStringNoSing()}\n";
                    
                    Addition(RgAExtended, RgCExtended, RgCorrected, mullA, mullB, Dmull, Sum);
                    Decremention(RgB, mullA, mullB, Dmull, Sum);

                    HistoryBox.Text += $"------------------------------------------------------------------\n";
                    HistoryBox.Text += $"{RgCExtended.BitsToStringNoSing()}\n\n";
                    HistoryBox.Text += $"RgB = {RgB.BitsToStringNoSing()}\n\n";

                }

                for (int i = 0; i < 4; i++)
                    RgC.SetBit(RgCExtended.GetBit(i), i + (length - lengthC)*4);

                for (int i = 0; i < 4; i++)
                {
                    ShitReg(RgCExtended, (length+1) * 4);
                    ShitReg(RgB, length * 4);
                }

                HistoryBox.Text += "Сдвиг!\n\n";
                HistoryBox.Text += $"RgC = {RgC.BitsToStringNoSing()}\n";
                HistoryBox.Text += $"RgCExtedned = {RgCExtended.BitsToStringNoSing()}\n";
                HistoryBox.Text += $"RgB = {RgB.BitsToStringNoSing()}\n\n\n";

                lengthC--;
            }

            for (int i = 0; i < length * 4; i++)
                RgC.SetBit(RgCExtended.GetBit(i), i + length * 4);

            RgC.sign = (byte)(RgA.sign & ~RgB.sign | ~RgA.sign & RgB.sign);
            NumCBinaryBox.Text = RgC.BitsToString();
            NumCDecimalBox.Text = BinaryToDecimal(RgC);
        }
        
        // Перевод из 10ой системы в 2ую
        private void DecimalToBinary(Register Reg, string Number)
        {
            for (int i = Number.Length - 1; i >= 0; i--)
            {
                int count = 0;
                int CurInd = Convert.ToInt32(Number[i].ToString());
                while (count < 3)
                {
                    Reg.SetBit((byte)(CurInd % 2), 4 * (Number.Length - 1 - i) + count);
                    CurInd /= 2;
                    count++;
                }
                Reg.SetBit((byte)CurInd, 4 * (Number.Length - 1 - i) + count);
            }
        }

        // Перевод из 2ой системы в 10ую
        private string BinaryToDecimal(Register Reg)
        {
            string result = "";
            int number = 0;
            for (int i = 0; i < length * 8; i++)
            {
                number += (Reg.GetBit(i) * (int)Math.Pow(2, i % 4));
                if ((i + 1) % 4 == 0)
                {
                    result = number.ToString() + result;
                    number = 0;
                }
            }

            while (result.Length > 0 && result[0] == '0')
                result = result.Substring(1);

            if (result.Length == 0)
                return "0";
            else
                return Reg.sign == 1 ? "-" + result : result;
        }

        private void Addition(Register RgAExt, Register RgСExt, CorrectedRegister RgCorrect, Multiplexor MullA, Multiplexor MullB, Demultiplexor DMull, Summator Sum)
        {

            TgP = 0;
            Ct = 0;
            isRepeat = true;

            // Начинаем складывать
            for (int i = 0; i < length*2+2; i++)
            {
                MullA.Multiplex(RgAExt, Ct);
                MullB.Multiplex(RgСExt, Ct);

                Sum.BeginIteration(MullA, MullB, ref TgP);

                DMull.Demultiplex(Sum, Ct);

                Ct += 2;

                if (Ct % 4 == 0)
                {
                    if (TgP == 1 || (DMull.GetBit(Ct - 1) == 1 && DMull.GetBit(Ct - 2) == 1 || DMull.GetBit(Ct - 1) == 1 && DMull.GetBit(Ct - 3) == 1))
                        RgCorrect.AddTetrad(Ct / 4 - 1);
                    else
                        RgCorrect.ClearTetrad(Ct / 4 - 1);
                }
            }

            DMull.BitsToReg(RgСExt);

            // Вносим поправки
            while (isRepeat) {
                isRepeat = false;
                TgP = 0;
                Ct = 0;

                for (int i = 0; i < length * 2 + 2; i++)
                {
                    MullA.Multiplex(RgСExt, Ct);
                    MullB.Multiplex(RgCorrect, Ct);

                    Sum.BeginIteration(MullA, MullB, ref TgP);

                    DMull.Demultiplex(Sum, Ct);

                    Ct += 2;

                    if (Ct % 4 == 0)
                    {
                        if (DMull.GetBit(Ct - 1) == 1 && DMull.GetBit(Ct - 2) == 1 || DMull.GetBit(Ct - 1) == 1 && DMull.GetBit(Ct - 3) == 1)
                        {
                            RgCorrect.AddTetrad(Ct / 4 - 1);
                            isRepeat = true;
                        }
                        else
                            RgCorrect.ClearTetrad(Ct / 4 - 1);
                    }
                }

                DMull.BitsToReg(RgСExt);
            }
        }

        private void Decremention(Register Reg, Multiplexor MullA, Multiplexor MullB, Demultiplexor DMull, Summator Sum)
        {
            Register DecrementRegister = new Register(4, 0);
            for (int i = 0; i < 4; i++)
                DecrementRegister.SetBit(1, i);

            TgP = 0;
            Ct = 0;

            for (int i = 0; i < 2; i++)
            {
                
                MullA.Multiplex(Reg, Ct);
                MullB.Multiplex(DecrementRegister, Ct);

                Sum.BeginIteration(MullA, MullB, ref TgP);

                DMull.Demultiplex(Sum, Ct);

                Ct += 2;
            }

            for (int i = 0; i < 4; i++)
                Reg.SetBit(DMull.GetBit(i), i);
        }

        private void CopyRegister(Register RegMain, Register RegCopied, int shift)
        {
            for (int i = 0; i < length * 4; i++)
                RegCopied.SetBit(RegMain.GetBit(i + shift), i);
        }

        private void ShitReg(Register Reg, int Length)
        {
            for (int i = 0; i < Length - 1; i++)
                Reg.SetBit(Reg.GetBit(i + 1), i);
            Reg.SetBit(0, Length - 1);
        }

        private bool IsNull(Register Reg)
        {
            if (Reg.GetBit(0) == 0 && Reg.GetBit(1) == 0 && Reg.GetBit(2) == 0 && Reg.GetBit(3) == 0)
                return false;
            return true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
