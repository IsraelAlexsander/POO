using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28   // Delegate FUNC e ACTION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Delta = {CalculaDelta(1,3,-4)}");
            Console.WriteLine($"Fatorial de 5 = {CalculaFatorial(5)}");
            Console.ReadKey();
            Console.Clear();

            Hello("World");
            Console.ReadKey();            
        }

        static Func<int, int, int, int> CalculaDelta = (a, b, c) => b * b - 4 * a * c;      // Expressão Lambda
        static Func<int, int> CalculaFatorial = n => (n == 0 ? 1 : n * CalculaFatorial(n - 1));     //Expressão Lambda + Operador Ternario
        static Action<string> Hello = Nome =>
        {
            string DizHello = "Hello " + Nome + "!!!";
            Console.WriteLine(DizHello);
        };
    }
}
