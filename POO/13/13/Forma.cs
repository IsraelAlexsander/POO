using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    public abstract class Forma
    {
        public double Area { get; set; }
        public double Perimetro { get; set; }

        public abstract void CalculaArea();
        public abstract void CalculaPerimetro();
        public virtual void Mensagem()
        {
            Console.Write("Agora estou calculando: ");
        }
    }
}
