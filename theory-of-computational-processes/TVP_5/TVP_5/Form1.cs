using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVP_5
{
    public partial class Form1 : Form
    {
        const int tetradLength = 4;
        public int Length;
        public byte TgP;
        public byte Ct;
        public bool isRepeat = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void startButtonClick(object sender, EventArgs e)
        {
            HistoryBox.Text = "";

            Length = NumADecimalBox.Text[0] == '-' ? NumADecimalBox.Text.Length - 1: NumADecimalBox.Text.Length;

            Register RgA = new Register(Length, NumADecimalBox.Text[0] == '-' ? (byte)1 : (byte)0);
            Register RgB = new Register(Length, NumBDecimalBox.Text[0] == '-' ? (byte)1 : (byte)0);
            Register RgC = new Register(Length, 0);

            CorrectedRegister RgCorrected = new CorrectedRegister(Length, 0);

            DecimalToBinary(RgA, RgA.signBit == 0 ? NumADecimalBox.Text : NumADecimalBox.Text.Substring(1));
            DecimalToBinary(RgB, RgB.signBit == 0 ? NumBDecimalBox.Text : NumBDecimalBox.Text.Substring(1));

            NumABinaryBox.Text = RgA.BitsToString();
            NumBbinaryBox.Text = RgB.BitsToString();

            Multiplexor mullA = new Multiplexor();
            Multiplexor mullB = new Multiplexor();

            Summator Sum = new Summator();

            Demultiplexor DMull = new Demultiplexor(Length);

            if (RgA.signBit == 1)
            {
                ToAdditionalCode(RgA, RgCorrected, mullA, mullB, Sum, DMull);
                HistoryBox.Text = HistoryBox.Text + $"Число А - отрицательное, перевод в дополнительный код:\n{RgA.BitsToString()}\n\n";
            }
            if (RgB.signBit == 1 && Add.Checked || RgB.signBit == 0 && Sub.Checked)
            {
                ToAdditionalCode(RgB, RgCorrected, mullA, mullB, Sum, DMull);
                RgB.signBit = 1;
                HistoryBox.Text = HistoryBox.Text + $"Число B - отрицательное, перевод в дополнительный код:\n{RgB.BitsToString()}\n\n";
            }
            else
                RgB.signBit = 0;

            TgP = 0;
            Ct = 0;

            for (int i = 0; i < Length*2; i++)
            {
                mullA.Multiplex(RgA, Ct);
                mullB.Multiplex(RgB, Ct);

                Sum.SumIteration(mullA, mullB, ref TgP);

                DMull.Demultiplex(Sum, Ct);

                Ct += 2;

                if (Ct % 4 == 0)
                {
                    HistoryBox.Text += $"Полученная тетрада = {DMull.demulReg[Ct - 1]}{DMull.demulReg[Ct - 2]}{DMull.demulReg[Ct - 3]}{DMull.demulReg[Ct - 4]}\n";
                    HistoryBox.Text += $"TgP = {TgP}\n";
                    if ((byte)(DMull.demulReg[Ct - 1] & DMull.demulReg[Ct - 2] | DMull.demulReg[Ct - 1] & DMull.demulReg[Ct - 3]) == 1 || TgP == 1)
                    {
                        RgCorrected.AddTetrad(Ct / 4 - 1);
                        HistoryBox.Text += $"Запрещенная комбинация, необходима поправка\n\n";
                    }
                    else
                        RgCorrected.ClearTetrad(Ct / 4 - 1);
                }
            }

            DMull.SetBits(RgC);

            RgC.signBit = (byte)(RgA.signBit & RgB.signBit & TgP | ~RgA.signBit & ~RgB.signBit & TgP | RgA.signBit & ~RgB.signBit & ~TgP | ~RgA.signBit & RgB.signBit & ~TgP);
            TgP = (byte)(RgA.signBit & RgB.signBit | RgA.signBit & TgP | RgB.signBit & TgP);

            if (TgP == 1)
            {
                for (int i = 0; i < Length; i++)
                {
                    if ((byte)(RgC.GetBit(i * 4 + 3) & RgC.GetBit(i * 4 + 2) | RgC.GetBit(i * 4 + 3) & RgC.GetBit(i * 4 + 1)) == 1)
                    {
                        RgCorrected.AddTetrad(i);
                    }
                }
            }

            repeatBegin:
            isRepeat = false;

            TgP = 0;
            Ct = 0;
            HistoryBox.Text = HistoryBox.Text + $"Промежуточный результат RgC - {RgC.BitsToString()}\n";
            HistoryBox.Text = HistoryBox.Text + $"Вводим поправки - {RgCorrected.BitsToString()}\n\n";

            for (int i = 0; i < Length * 2; i++)
            {
                mullA.Multiplex(RgC, Ct);
                mullB.Multiplex(RgCorrected, Ct);

                Sum.SumIteration(mullA, mullB, ref TgP);

                DMull.Demultiplex(Sum, Ct);

                Ct += 2;

                if (Ct % 4 == 0)
                {
                    HistoryBox.Text += $"Полученная тетрада = {DMull.demulReg[Ct - 1]}{DMull.demulReg[Ct - 2]}{DMull.demulReg[Ct - 3]}{DMull.demulReg[Ct - 4]}\n";
                    if ((byte)(DMull.demulReg[Ct - 1] & DMull.demulReg[Ct - 2] | DMull.demulReg[Ct - 1] & DMull.demulReg[Ct - 3]) == 1)
                    {
                        RgCorrected.AddTetrad(Ct / 4 - 1);
                        isRepeat = true;
                        HistoryBox.Text += $"Запрещеная комбинация, необходима поправка\n\n";
                    }
                    else
                        RgCorrected.ClearTetrad(Ct / 4 - 1);
                }
            }

            DMull.SetBits(RgC);

            byte RgCSign = RgC.signBit;

            RgC.signBit = (byte)(RgC.signBit & RgCorrected.signBit & TgP | ~RgC.signBit & ~RgCorrected.signBit & TgP | RgC.signBit & ~RgCorrected.signBit & ~TgP | ~RgC.signBit & RgCorrected.signBit & ~TgP);
            TgP = (byte)(RgCSign & RgCorrected.signBit | RgCSign & TgP | RgCorrected.signBit & TgP);


            for (int i = 0; i < Length; i++)
            {
                if ((byte)(RgC.GetBit(i * 4 + 3) & RgC.GetBit(i * 4 + 2) | RgC.GetBit(i * 4 + 3) & RgC.GetBit(i * 4 + 1)) == 1)
                {
                    RgCorrected.AddTetrad(i);
                    isRepeat = true;
                }
                else
                    RgCorrected.ClearTetrad(i);
            }
            
            if (isRepeat)
            {
                HistoryBox.Text = HistoryBox.Text + $"Повторяем корректировку...\n";
                goto repeatBegin;
            }

        repeatEnd:
            isRepeat = false;

            if (RgC.signBit == 1)
            {
                HistoryBox.Text = HistoryBox.Text + $"Промежуточный результат RgC - {RgC.BitsToString()}\nПереводим из дополнительного в прямой код...\n\n";
                ToAdditionalCode(RgC, RgCorrected, mullA, mullB, Sum, DMull);
                for (int i = 0; i < Length; i++)
                {
                    if (RgC.GetBit(i * 4 + 1) == 1 && RgC.GetBit(i * 4 + 3) == 1)
                    {
                        isRepeat = true;
                        RgCorrected.AddTetrad(i);
                    }
                    else
                        RgCorrected.ClearTetrad(i);
                }
            }

            isRepeat = false;

            TgP = 0;
            Ct = 0;
            HistoryBox.Text = HistoryBox.Text + $"Промежуточный результат RgC - {RgC.BitsToString()}\n";
            HistoryBox.Text = HistoryBox.Text + $"Вводим поправки - {RgCorrected.BitsToString()}\n\n";

            for (int i = 0; i < Length * 2; i++)
            {
                mullA.Multiplex(RgC, Ct);
                mullB.Multiplex(RgCorrected, Ct);

                Sum.SumIteration(mullA, mullB, ref TgP);

                DMull.Demultiplex(Sum, Ct);

                Ct += 2;

                if (Ct % 4 == 0)
                {
                    if ((byte)(DMull.demulReg[Ct - 1] & DMull.demulReg[Ct - 2] | DMull.demulReg[Ct - 1] & DMull.demulReg[Ct - 3]) == 1)
                    {
                        RgCorrected.AddTetrad(Ct / 4 - 1);
                        isRepeat = true;
                    }
                    else
                        RgCorrected.ClearTetrad(Ct / 4 - 1);
                }
            }

            DMull.SetBits(RgC);

            RgCSign = RgC.signBit;

            RgC.signBit = (byte)(RgC.signBit & RgCorrected.signBit & TgP | ~RgC.signBit & ~RgCorrected.signBit & TgP | RgC.signBit & ~RgCorrected.signBit & ~TgP | ~RgC.signBit & RgCorrected.signBit & ~TgP);
            TgP = (byte)(RgCSign & RgCorrected.signBit | RgCSign & TgP | RgCorrected.signBit & TgP);

            if (isRepeat)
                goto repeatEnd;

            NumCDecimalBox.Text = BinaryToDecimal(RgC);
            NumCBinaryBox.Text = RgC.BitsToString();
        }

        private void DecimalToBinary(Register Reg, string Number)
        {
            for (int i = Number.Length-1; i >= 0; i--)
            {
                int count = 0;
                int currentIndex = Convert.ToInt32(Number[i].ToString());
                while (count < 3)
                {
                    Reg.SetBit((byte)(currentIndex % 2), 4 * (Number.Length - 1 - i) + count);
                    currentIndex /= 2;
                    count++;
                }
                Reg.SetBit((byte)currentIndex, 4 * (Number.Length - 1 - i) + count);
            }
        }

        private string BinaryToDecimal(Register Reg)
        {
            string result = "";
            int num = 0;
            for (int i = 0; i < Length*4; i++)
            {
                num += (Reg.GetBit(i)*(int)Math.Pow(2, i % 4));
                if ((i + 1) % 4 == 0)
                {
                    result = num.ToString() + result;
                    num = 0;
                }
            }

            while (result.Length > 0 && result[0] == '0')
                result = result.Substring(1);

            if (result.Length == 0)
                return "0";
            else
                return Reg.signBit == 1 ? "-" + result : result;
        }

        private void ToAdditionalCode(Register Reg, CorrectedRegister RegCorrected, Multiplexor MullA, Multiplexor MullB, Summator Sum, Demultiplexor DMull)
        {
            TgP = 0;
            Ct = 0;
            PrepareRegToCorrect(RegCorrected);
            for (int i = 0; i < Length*2; i++)
            {
                MullA.Multiplex(Reg, Ct);
                MullB.Multiplex(RegCorrected, Ct);

                Sum.SumIteration(MullA, MullB, ref TgP);

                DMull.Demultiplex(Sum, Ct);
                Ct += 2;

            }

            DMull.SetBits(Reg);

            for(int i = 0; i < Length *4; i++)
                Reg.InvertBit(i);

            TgP = 1;
            Increment(Reg, ref TgP);

        }

        private void Increment(Register Reg, ref byte TgP)
        {
            for (int i = 0; i < Length*4; i++)
            {
                byte currentIndex = Reg.GetBit(i);
                Reg.SetBit((byte)(Reg.GetBit(i) & ~TgP | ~Reg.GetBit(i) & TgP), i);
                TgP = (byte)(currentIndex & TgP);
            }
        }


        private void PrepareRegToCorrect(CorrectedRegister RgCorrected)
        {
            for (int i = 0; i < Length; i++)
                RgCorrected.AddTetrad(i);
        }

    }
}
