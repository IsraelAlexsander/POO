using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Vetor = { 2, 8, 3, 1, 9, 7, 6, 4, 5, 0 };

            int TotalPares = Vetor.Where(x => x % 2 == 0).Count(); // -x Faz a ordem inversa

            Console.WriteLine($"O vetor tem {TotalPares} números pares...");

            Console.ReadKey();

            Array.Sort(Vetor, (x, y) => x.CompareTo(y));

            foreach(int i in Vetor)
            {
                Console.Write($"{i,6}");
            }
            Console.ReadKey();
        }
    }
}
