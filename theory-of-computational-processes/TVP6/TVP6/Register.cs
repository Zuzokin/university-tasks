using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP6
{
    internal class Register
    {
        public byte sign;
        protected byte[] bits;

        public byte GetBit(int CurInd) => bits[CurInd];

        public void SetBit(byte value, int CurInd) => bits[CurInd] = value;

        public void InvertBit(int CurInd) => bits[CurInd] = bits[CurInd] == 1 ? (byte)0 : (byte)1;

        public string BitsToString()
        {
            string result = "";
            string line = String.Join("", bits);
            for (int i = 0; i < bits.Length / 4; i++)
            {
                string curLine = line.Substring(i * 4, 4);
                char[] arr = curLine.ToArray();
                Array.Reverse(arr);
                result = i == 0 ? String.Join("", arr) + result : String.Join("", arr) + "." + result;
            }

            result = $"{sign}." + result;

            return result;
        }

        public string BitsToStringNoSing()
        {
            string result = "";
            string line = String.Join("", bits);
            for (int i = 0; i < bits.Length / 4; i++)
            {
                string curLine = line.Substring(i * 4, 4);
                char[] arr = curLine.ToArray();
                Array.Reverse(arr);
                result = i == 0 ? String.Join("", arr) + result : String.Join("", arr) + "." + result;
            }

            return result;
        }

        public Register(int length, byte sign)
        {
            bits = new byte[length * 4];
            this.sign = sign;
        }
    }
}
