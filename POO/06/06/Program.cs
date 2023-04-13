using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            fatorial f = new fatorial();
            superFatorial sF = new superFatorial();

            Console.Write("Digite o valor do super fatorial: ");
            n = int.Parse(Console.ReadLine());            

            Console.WriteLine($"O Fatorial de {n} é: {f.calcFatorial(n)}");
            Console.WriteLine($"O Super Fatorial de {n} é: {sF.calcSuperFat(n)}");

            Console.ReadKey();
        }
    }
}
