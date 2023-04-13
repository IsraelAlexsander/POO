using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal abstract class AnaliseCombinatoria
    {
        public virtual int Fatorial(int n)
        {
            if (n == 1) 
                return 1;
            else
            {
                return n * Fatorial(n - 1);
            }            
        }
        public abstract int Calcular();
    }
}
