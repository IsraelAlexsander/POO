using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Combinacao
    {
        public int N { get; set; }
        public int P { get; set; }
        public int Calcular(Calculo C)
        {
            return C.Combinacao(N, P);
        }
    }
}
