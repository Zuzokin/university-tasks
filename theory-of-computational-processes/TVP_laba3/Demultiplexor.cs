using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_Laba1
{
    internal class Demultiplexor
    {
        private readonly Register mullReg;
        public Demultiplexor(int size) => mullReg = new(size);
        public Register MullRegister => mullReg;

        public void Demultiplex(Summator reg, int counter) 
        {
            for (int bit = 0; bit < reg.SumRegister.GetSize(); bit++)
                mullReg.SetBit(bit + counter, reg.SumRegister.GetBit(bit));
        }
        public void SetBits(Register reg)
        {
            for (int bit = 0; bit < MullRegister.GetSize(); bit++)
                reg.SetBit(bit, mullReg.GetBit(bit));
        }

    }
}
