using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_Laba1
{
    internal class Summator
    {
        private readonly Register sumReg;
        //private bool transferSign;
        public Summator(int size) => sumReg = new(size);

        public Register SumRegister => sumReg;
        //public int TransferSign() => transferSign ? 1 : 0;
        //public void ResetTransferSign() => transferSign = false;
        //public void SetTransferSign(int value) => transferSign = value !=0;

        public void Interation(Multiplexor mullA, Multiplexor mullB, ref int tgP)
        {
            for (int bit = 0; bit < mullA.MuxRegister.GetSize(); bit++)
            {
                sumReg.SetBit(bit, mullA.MuxRegister.GetBit(bit) ^ mullB.MuxRegister.GetBit(bit) ^ tgP);
                tgP = 
                    mullA.MuxRegister.GetBit(bit) & mullB.MuxRegister.GetBit(bit) |
                    mullA.MuxRegister.GetBit(bit) & tgP |
                    mullB.MuxRegister.GetBit(bit) & tgP;
            }
        }

    }
}
