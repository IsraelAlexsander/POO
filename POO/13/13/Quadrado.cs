using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    internal class Quadrado : Forma
    {
        public double Lado { get; set; }

        public override void CalculaArea()
        {
            this.Area = Math.Pow(Lado, 2);
        }

        public override void CalculaPerimetro()
        {
            this.Perimetro = 4 * Lado;
        }

        public override void Mensagem()
        {
            base.Mensagem();
            Console.WriteLine("Quadrado\n");
        }
    }
}
