using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP6
{
    internal class Multiplexor
    {
        private byte[] muxReg;
        public byte GetBit(int CurInd) => muxReg[CurInd];

        public void Multiplex(Register Reg, byte count)
        {
            for (int i = 0; i < 2; i++)
                muxReg[i] = Reg.GetBit(i + count);
        }

        public Multiplexor()
        {
            muxReg = new byte[2];
        }
    }
}
