using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_5
{
    public class CorrectedRegister : Register
    {

        public void AddTetrad(int cur_tetrad)
        {
            bits[cur_tetrad * 4] = 0;
            bits[cur_tetrad * 4 + 1] = 1;
            bits[cur_tetrad * 4 + 2] = 1;
            bits[cur_tetrad * 4 + 3] = 0;
        }

        public void ClearTetrad(int cur_tetrad)
        {
            bits[cur_tetrad * 4] = 0;
            bits[cur_tetrad * 4 + 1] = 0;
            bits[cur_tetrad * 4 + 2] = 0;
            bits[cur_tetrad * 4 + 3] = 0;
        }

        public CorrectedRegister(int length, byte sign)
            :base(length, sign)
        {
        }
    }
}
