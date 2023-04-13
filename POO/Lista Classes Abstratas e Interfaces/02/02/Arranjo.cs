using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Arranjo
    {
        public int N { get; set; }
        public int P { get; set; }

        public int Calcular(Calculo C)
        {
            return C.Arranjo(N, P);
        }
    }
}
