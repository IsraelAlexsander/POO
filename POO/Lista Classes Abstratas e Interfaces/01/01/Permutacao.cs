using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class Permutacao : AnaliseCombinatoria
    {
        public int N { get; set; }
        public override int Calcular()
        {
            return Fatorial(N);
        }
    }
}
