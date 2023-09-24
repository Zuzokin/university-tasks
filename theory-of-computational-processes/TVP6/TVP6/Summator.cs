using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP6
{
    internal class Summator
    {
        private byte[] bits;

        public byte transferSign; // признак переноса

        public void SetBit(int bitIndex, byte value) => bits[bitIndex] = value;
        public byte GetBit(int bitIndex) => bits[bitIndex];

        public void BeginIteration(Multiplexor MullA, Multiplexor MullB, ref byte TgP)
        {
            transferSign = TgP;
            for (int i = 0; i < 2; i++)
            {
                // Просчет бита
                byte curBit = (byte)(MullA.GetBit(i) & MullB.GetBit(i) & transferSign | MullA.GetBit(i) & ~MullB.GetBit(i) & ~transferSign | ~MullA.GetBit(i) & MullB.GetBit(i) & ~transferSign | ~MullA.GetBit(i) & ~MullB.GetBit(i) & transferSign);
                bits[i] = curBit;
                // Просчет бита переноса
                transferSign = (byte)(MullA.GetBit(i) & MullB.GetBit(i) | MullA.GetBit(i) & transferSign | MullB.GetBit(i) & transferSign);
            }
            TgP = transferSign;
        }

        public Summator()
        {
            bits = new byte[2];
            transferSign = 0;
        }
    }
}
