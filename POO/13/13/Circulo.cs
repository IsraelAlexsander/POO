using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    internal class Circulo : Forma
    {
        public double Raio { get; set; }
        public override void CalculaArea()
        {
            this.Area = Math.PI * Math.Pow(Raio, 2);
        }

        public override void CalculaPerimetro()
        {
            this.Perimetro = 2 * Math.PI * Raio;
        }

        public override void Mensagem()
        {
            base.Mensagem();
            Console.WriteLine("Circulo\n");
        }
    }
}
