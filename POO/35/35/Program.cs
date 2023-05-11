using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35   // Tratamento de Exceções
{
    class RaizQuadradaException : Exception
    {
        public RaizQuadradaException(string MSG) : base(MSG) 
        {

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int X;
            double Raiz = 0;

            Console.Write("Digite um número: ");
            X = int.Parse(Console.ReadLine());

            try
            {
                Raiz = CalculaRaiz(X);
            }
            catch (RaizQuadradaException e)
            {
                Console.WriteLine("\n\nERRO no cálculo da raíz quadrada!");
                Console.WriteLine(e.Message);
            }

            if (Raiz != 0)
                Console.WriteLine($"A raíz quadrade de x é: {Raiz}");
        }

        static double CalculaRaiz(int x)
        {
            if (x < 0)
                throw new RaizQuadradaException("\nPô, tem que ser número positivo...");

            return Math.Sqrt(x);
        }
    }
}
