using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_5
{
    public class Register
    {
        public byte signBit;
        protected byte[] bits;

        public byte GetBit(int currentIndex) => bits[currentIndex];

        public void SetBit(byte value, int currentIndex) => bits[currentIndex] = value; 
        
        public void InvertBit(int currentIndex) => bits[currentIndex] = bits[currentIndex] == 1 ? (byte)0 : (byte)1;

        public string BitsToString()
        {
            string result = "";
            string line = String.Join("", bits);
            for (int i = 0; i < bits.Length/4; i++)
            {
                string curLine = line.Substring(i*4, 4);
                char[] arr = curLine.ToArray();
                Array.Reverse(arr);
                result = i == 0 ?  String.Join("", arr) + result : String.Join("", arr) + "." + result;
            }

            result = $"{signBit}." + result;

            return result;
        }

        public Register(int length, byte sign)
        {
            bits = new byte[length * 4];
            signBit = sign;
        }
    }
}
