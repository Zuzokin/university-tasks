using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_5
{
    internal class Demultiplexor
    {
        public byte[] demulReg;

        public void SetBits(Register Reg)
        {
            for (int i = 0; i < demulReg.Length; i++)
                Reg.SetBit(demulReg[i], i);
        }

        public void Demultiplex(Summator Sum, byte count)
        {
            for (int i = 0; i < 2; i++)
                demulReg[i + count] = Sum.GetBit(i);
        }

        public Demultiplexor(int tetradIndex)
        {
            demulReg = new byte[tetradIndex*4];
        }

    }
}
