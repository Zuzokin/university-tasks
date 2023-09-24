using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP6
{
    internal class CorrectedRegister : Register
    {
        public void AddTetrad(int tetradIndex)
        {
            bits[tetradIndex * 4] = 0;
            bits[tetradIndex * 4 + 1] = 1;
            bits[tetradIndex * 4 + 2] = 1;
            bits[tetradIndex * 4 + 3] = 0;
        }

        public void ClearTetrad(int tetradIndex)
        {
            bits[tetradIndex * 4] = 0;
            bits[tetradIndex * 4 + 1] = 0;
            bits[tetradIndex * 4 + 2] = 0;
            bits[tetradIndex * 4 + 3] = 0;
        }

        public CorrectedRegister(int length, byte sign)
            : base(length, sign)
        {
        }
    }
}
