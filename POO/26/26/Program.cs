using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Vetor = { 2, 8, 3, 1, 9, 7, 6, 4, 5, 0 };

            var VetorFiltrado = Vetor.Where(x => x > 5);

            foreach(int Valor in VetorFiltrado)
            {
                Console.Write($"{Valor,6}");
            }

            Console.ReadKey();
            Console.Clear();

            var OutroVetorFiltrado = Vetor.Where(Filtro);

            foreach (int Valor in OutroVetorFiltrado)
            {
                Console.Write($"{Valor,6}\n");
            }
            Console.ReadKey();
        }

        static bool Filtro(int x)
        {
            Console.WriteLine($"Testando o valor {x}");

            return x > 5;
        }
    }
}
