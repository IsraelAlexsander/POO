using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cilindro xC = new cilindro();

            double raio;
            double altura;
            double volume;

            Console.Write("Raio do cilíndro: ");
            raio = double.Parse(Console.ReadLine());

            Console.Write("Altura do cilíndro: ");
            altura = double.Parse(Console.ReadLine());

            volume = xC.calcVolume(raio, altura);

            Console.WriteLine($"\nVolume do cilíndro: {volume:F2}");

            Console.ReadKey();
        }
    }
}
