using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_5
{
    internal class Summator
    {
        private byte[] bits;

        public byte transferSing; // признак переноса

        public void SetBit(int currentIndex, byte value) => bits[currentIndex] = value;
        public byte GetBit(int currentIndex) => bits[currentIndex];

        public void SumIteration(Multiplexor Mull_A, Multiplexor Mull_B, ref byte TgP)
        {
            transferSing = TgP;
            for (int i = 0; i < 2; i++)
            {
                // Просчет бита
                byte now_bit = (byte)(Mull_A.GetBit(i) & Mull_B.GetBit(i) & transferSing | Mull_A.GetBit(i) & ~Mull_B.GetBit(i) & ~transferSing | ~Mull_A.GetBit(i) & Mull_B.GetBit(i) & ~transferSing | ~Mull_A.GetBit(i) & ~Mull_B.GetBit(i) & transferSing);
                bits[i] = now_bit;
                // Просчет бита переноса
                transferSing = (byte)(Mull_A.GetBit(i) & Mull_B.GetBit(i) | Mull_A.GetBit(i) & transferSing | Mull_B.GetBit(i) & transferSing);
            }
            TgP = transferSing;
        }

        public Summator()
        {
            bits = new byte[2];
            transferSing = 0;
        }

    }
}
