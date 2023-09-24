namespace TVP_Laba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            historyTextBox.Clear();
            textBoxBinaryA.Clear();
            textBoxBinaryB.Clear();
            textBoxBinaryResult.Clear();
            textBoxDecimalResult.Clear();

            int sumSize = 2;
            int operandSize = 32;
            int doubleOperandSize = 64;
            int Ct;
            int TgP = 0;
            int sign = 0;


            Register RgA = new(doubleOperandSize);      //множимое
            Register RgB = new(operandSize);            //счетчик
            Register RgC = new(doubleOperandSize);      //СЧП
            Multiplexor mullA = new(sumSize);
            Multiplexor mullB = new(sumSize);
            Summator sum = new(sumSize);
            Demultiplexor demull = new(doubleOperandSize);

            DecimalToBinary(RgA, Convert.ToInt32(textBoxDecimalA.Text));
            DecimalToBinary(RgB, Convert.ToInt32(textBoxDecimalB.Text));

            sign = RgA.GetBit(RgA.GetSize() - 1) ^ RgB.GetBit(RgB.GetSize() - 1);
            RgA.LeftShift(operandSize);
            RgB.ResetBit(RgB.GetSize() - 1);

            historyTextBox.Text += $"Перевели число А в двоичный вид  - {RgA.BitsToString()}\n";
            historyTextBox.Text += $"Перевели число B в двоичный вид  - {RgB.BitsToString()}\n";

            RgC.ResetAllBits();

            textBoxBinaryA.Text = RgA.BitsToString();
            textBoxBinaryB.Text = RgB.BitsToString();

            historyTextBox.Text += $"Умножение:\n";
            for (int i = 0; i < operandSize; i++)
            {
                historyTextBox.Text += $"Итерация #{i}\n";
                RgA.RightShift(1);
                historyTextBox.Text += $"Сдвиг множимого вправо на 1 - {RgA.BitsToString()}\n";
                if (RgB.GetBit(operandSize - 1 - i) == 1)
                {
                    Ct = 0;
                    historyTextBox.Text += $"Сложение множимого с СЧП:{RgC.BitsToString()}\n";
                    for (int j = 0; j < doubleOperandSize / 2; j++)
                    {
                        mullA.Multiplex(RgA, Ct);
                        mullB.Multiplex(RgC, Ct);
                        historyTextBox.Text += $"Значения мультиплексора А - {mullA.MuxRegister.BitsToString()}\n";
                        historyTextBox.Text += $"Значения мультиплексора B - {mullB.MuxRegister.BitsToString()}\n";
                        sum.Interation(mullA, mullB, ref TgP);
                        historyTextBox.Text += $"Значения сумматора - {sum.SumRegister.BitsToString()}\nЗначение триггера переноса - {TgP}\n\n";
                        demull.Demultiplex(sum, Ct);
                        Ct += 2;
                    }
                    demull.SetBits(RgC);
                }
            }


            // Вывод для белковых
            if (sign == 1)
            {
                RgC.SetBit(RgC.GetSize() - 1);
                historyTextBox.Text += $"Получили результат в регистре C - {RgC.BitsToString()}\n";
                textBoxDecimalResult.Text += "-";
            }
            textBoxBinaryResult.Text = RgC.BitsToString();
            textBoxDecimalResult.Text += Convert.ToString(BinaryToDecimal(RgC));
        }


        private static void DecimalToBinary(Register reg, int value)
        {
            if (value < 0)
                reg.SetBit(reg.GetSize() - 1);
            value = Math.Abs(value);
            int index = 0;

            while (value >= 2)
            {
                reg.SetBit(index, Convert.ToByte(value % 2));
                value /= 2;
                index++;
            }
            reg.SetBit(index, Convert.ToByte(value));
        }

        private static int BinaryToDecimal(Register reg)
        {
            int result = 0;
            for (int i = 0; i < reg.GetSize() - 1; i++)
            {
                result += (reg.GetBit(i) == 1) ? 1 << i : 0;
            }
            return result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}