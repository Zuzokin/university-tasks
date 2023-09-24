using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP6
{
    internal class Demultiplexor
    {
        public byte[] demulReg;

        public byte GetBit(int CurInd) => demulReg[CurInd];

        public void Set_Bit(byte value, int CurInd) => demulReg[CurInd] = value;

        public void BitsToReg(Register Reg)
        {
            for (int i = 0; i < demulReg.Length; i++)
                Reg.SetBit(demulReg[i], i);
        }

        public void Demultiplex(Summator Sum, byte count)
        {
            for (int i = 0; i < 2; i++)
                demulReg[i + count] = Sum.GetBit(i);
        }

        public Demultiplexor(int TetradQuantity)
        {
            demulReg = new byte[TetradQuantity * 4];
        }
    }
}
