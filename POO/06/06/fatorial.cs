using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    internal class fatorial
    {
        public int calcFatorial(int n)
        {
            return n == 0 ? 1 : (n * calcFatorial(n - 1));

            //int fat = 1;

            //for (int i = n; i > 0; i--)
            //{
            //    fat *= i;
            //}

            //return fat;
        }
    }
}
