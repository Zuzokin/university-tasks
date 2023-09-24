using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_Laba1
{
    internal class Register
    {
        private readonly BitArray value = new(0);
        public Register(int size) => value.Length = size;     
        
        public string BitsToString()
        {
            var strReg = new StringBuilder(value.Length);
            for (int bit = value.Length-1; bit >= 0; bit--)
                strReg.Append(value[bit] ? "1" : "0");
            return strReg.ToString();
        }
        
        public void SetBit(int index) => value.Set(index, true); 
        public void SetBit(int index, int state) => value.Set(index, state != 0);
        public int GetBit(int index) => Convert.ToInt32(value.Get(index));
        public void InverseBit(int index) => value.Set(index, (value.Get(index) ^ true));
        public void ResetBit(int index) => value.Set(index, (value.Get(index) & false));
        public int GetSize() => value.Length;

    }
}
