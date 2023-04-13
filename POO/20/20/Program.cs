using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vetor MeuVetor = new Vetor();

            MeuVetor.Mostrar();

            MeuVetor.Ordena(new MyComparador());

            Console.WriteLine();

            MeuVetor.Mostrar();
        }
    }
}
