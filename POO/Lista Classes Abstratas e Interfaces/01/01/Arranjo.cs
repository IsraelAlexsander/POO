using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class Arranjo : AnaliseCombinatoria
    {
        public int N { get; set; }
        public int P { get; set; }
        public override int Calcular()
        {
            return Fatorial(N) / Fatorial(N - P);
        }
    }
}
