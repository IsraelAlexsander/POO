using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado xQuadrado = new Quadrado();
            Circulo xCirculo = new Circulo();

            xQuadrado.Mensagem();

            Console.Write("Lado do quadrado: ");
            xQuadrado.Lado = double.Parse(Console.ReadLine());

            xQuadrado.CalculaArea();
            xQuadrado.CalculaPerimetro();

            Console.WriteLine($"Área do Quadrado: {xQuadrado.Area:F2}");
            Console.WriteLine($"Perímetro do Quadrado: {xQuadrado.Perimetro:F2}");

            Console.ReadKey();
            Console.WriteLine();

            xCirculo.Mensagem();

            Console.Write("Raio do Circulo: ");
            xCirculo.Raio = double.Parse(Console.ReadLine());

            xCirculo.CalculaArea();
            xCirculo.CalculaPerimetro();

            Console.WriteLine($"Área do Círculo: {xCirculo.Area:F2}");
            Console.WriteLine($"Perímetro do Círculo: {xCirculo.Perimetro:F2}");

            Console.ReadKey();            
        }
    }
}
