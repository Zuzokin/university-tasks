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
            int operandSize = 4;
            int doubleOperandSize = 8;
            int Ct = 0;
            int TgP = 0;
            int sign;


            Register RgA = new(doubleOperandSize); //��������� ������� ��� �������
            Register RgB = new(operandSize); //��������
            Register RgC = new(operandSize); //�������
            Multiplexor mullA = new(sumSize);
            Multiplexor mullB = new(sumSize);
            Summator sum = new(sumSize);
            Demultiplexor demull = new(operandSize);

            DecimalToBinary(RgA, Convert.ToInt32(textBoxDecimalA.Text));
            historyTextBox.Text += $"�������� ������������� ����� � � �������� ���  - {RgA.BitsToString()}\n";
            DecimalToBinary(RgB, Convert.ToInt32(textBoxDecimalB.Text));
            historyTextBox.Text += $"�������� ������������� ����� B � �������� ���  - {RgA.BitsToString()}\n";

            textBoxBinaryA.Text = RgA.BitsToString();
            textBoxBinaryB.Text = RgB.BitsToString();



            historyTextBox.Text += $"��������:\n";
            for (int i = 0; i < operandSize / 2; i++)
            {
                mullA.Multiplex(RgA, Ct);
                mullB.Multiplex(RgB, Ct);
                historyTextBox.Text += $"�������� �������������� � - {mullA.MuxRegister.BitsToString()}\n";
                historyTextBox.Text += $"�������� �������������� B - {mullB.MuxRegister.BitsToString()}\n";
                sum.Interation(mullA, mullB, ref TgP);
                historyTextBox.Text += $"�������� ��������� - {sum.SumRegister.BitsToString()}\n�������� �������� �������� - {TgP}\n\n";
                demull.Demultiplex(sum, Ct);
                Ct += 2;
            }

            demull.SetBits(RgC);
            historyTextBox.Text += $"�������� ��������� � �������� C - {RgC.BitsToString()}\n";

            if (RgC.GetBit(operandSize - 1) == 0)
            {
                textBoxBinaryResult.Text = RgC.BitsToString();
                textBoxDecimalResult.Text = Convert.ToString(BinaryToDecimal(RgC));
            }
            //else
            //{
            //    textBoxBinaryResult.Text = Convert.ToString(Convert.ToInt32(RgC.BitsToString(), 2), 2);
            //    textBoxDecimalResult.Text = Convert.ToString(Convert.ToInt32(RgC.BitsToString(), 2));
            //}
            else
            {
                textBoxDecimalResult.Text = Convert.ToString(Convert.ToInt32(RgC.BitsToString(), 2));
                TgP = 0;
                Ct = 0;
                for (int i = 0; i < RgA.GetSize(); i++)
                    RgA.SetBit(i);

                for (int i = 0; i < 16; i++)
                {
                    mullA.Multiplex(RgA, Ct);
                    mullB.Multiplex(RgC, Ct);

                    sum.Interation(mullA, mullB, ref TgP);

                    demull.Demultiplex(sum, Ct);
                    Ct += 2;
                }
                demull.SetBits(RgC);

                for (int i = 0; i < RgC.GetSize() - 1; i++)
                    RgC.InverseBit(i);
                textBoxBinaryResult.Text = RgC.BitsToString();
            }
        }


        private static void DecimalToBinary(Register reg, int value)
        {
            if (value < 0)
                reg.SetBit(reg.GetSize() - 1, 1);
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
            for (int i = 0; i < reg.GetSize(); i++)
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