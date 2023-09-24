using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_Laba1
{
    internal class Multiplexor
    {
        private readonly Register muxReg;
        public Multiplexor(int size) => muxReg = new(size);
        
        public Register MuxRegister => muxReg; 
        public void Multiplex(Register reg, int counter)
        {
            for (int bit = 0; bit < muxReg.GetSize(); bit++)
                muxReg.SetBit(bit, reg.GetBit(bit + counter));
        }
    }
}
