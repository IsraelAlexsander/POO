using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24
{
    internal class Multiplicacao : EstrategiaOperacao
    {
        public override int ExecuteOperacao(int A, int B)
        {
            return A * B;
        }
    }
}
