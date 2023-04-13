using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.Write("A = ");
            a = double.Parse(Console.ReadLine());

            Console.Write("B = ");
            b = double.Parse(Console.ReadLine());

            Console.Write("C = ");
            c = double.Parse(Console.ReadLine());

            xRaizes eq2Grau = new xRaizes();

            eq2Grau.calcRaizes(a, b, c);

            Console.WriteLine($"Delta = {eq2Grau.delta:F2}\n");

            if (eq2Grau.delta >= 0)
            {
                Console.WriteLine($"Raíz 1 = {eq2Grau.raiz1:F2}");
                Console.WriteLine($"Raíz 2 = {eq2Grau.raiz2:F2}\n");
            }
            else
            {
                Console.WriteLine("Não existem raízes reais para a equação");
            }

            Console.ReadKey();
        }
    }
}
