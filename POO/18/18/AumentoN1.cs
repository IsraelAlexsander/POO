using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    internal class AumentoN1 : EstrategiaAumento
    {
        public override double Execute(double Salario)
        {
            return Salario + Salario * 6 / 100; // return Salario + (double)Salario * 6 / 100;
        }
    }
}
