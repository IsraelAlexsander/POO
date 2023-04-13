using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Calculo : IAnaliseCombinatoria
    {        
        public int Fatorial(int n)
        {
            if (n == 1)
                return 1;
            else
            {
                return n * Fatorial(n - 1);
            }
        }
        public int Permutacao(int n)
        {
            return Fatorial(n);
        }
        public int Arranjo(int n, int p)
        {
            return Fatorial(n) / Fatorial(n - p);
        }

        public int Combinacao(int n, int p)
        {
            return Fatorial(n) / (Fatorial(p) * Fatorial(n - p));
        }               
    }
}
