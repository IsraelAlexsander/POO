using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    internal class AumentoN3 : EstrategiaAumento
    {
        public override double Execute(double Salario)
        {
            return Salario + Salario * 2 / 100;  // return Salario + (double)Salario * 2 / 100;
        }
    }
}
