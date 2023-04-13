using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    internal class superFatorial : fatorial
    {
        public int calcSuperFat(int n)
        {
            int superFat = 1;

            for (int i = n; i > 0; i--)
            {
                superFat *= calcFatorial(i);                
            }
            return superFat;
        }
    }
}
