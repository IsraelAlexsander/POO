using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    internal class MyComparador : IMyComparador
    {
        public int Compara(int x, int y)
        {
            if (x == y) return 0;
            else if (x > y) return 1;
            else return -1;            
        }
    }
}