using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34   // Tratamento de exceções
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Fat;
            int N;
            int Result;

            Console.Write("Digite um número de 1 a 15: ");
            N = int.Parse(Console.ReadLine());

            Fat = 0;

            try
            {
                Fat = CalcularFat(N);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("\nERRO! \n");
                Console.WriteLine(e.Message);
            }

            if (Fat != 0)
            {
                Console.WriteLine($"O fatorial de {N} é {Fat}");
            }

            Console.ReadKey();
        }

        static int CalcularFat(int N)
        {
            if (N < 0 || N > 15)
                throw new ArgumentException("\n\n Faixa de calculo inválida!\n");

            if (N == 0)
                return 1;
            else
                return N * CalcularFat(N - 1);
        }
    }
}
