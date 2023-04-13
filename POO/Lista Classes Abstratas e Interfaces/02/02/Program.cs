using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Permutacao MinhaPermutacao = new Permutacao();
            Arranjo MeuArranjo = new Arranjo();
            Combinacao MinhaCombinacao = new Combinacao();

            Console.WriteLine("Permutação");
            Console.Write("Digite o valor de n: ");
            MinhaPermutacao.N = int.Parse(Console.ReadLine());
            Console.WriteLine($"P(n) = {MinhaPermutacao.Calcular(new Calculo())}");
            Console.ReadKey();

            Console.WriteLine("\nArranjo");
            Console.Write("Digite o valor de n: ");
            MeuArranjo.N = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de p: ");
            MeuArranjo.P = int.Parse(Console.ReadLine());
            Console.WriteLine($"A(n,p) = {MeuArranjo.Calcular(new Calculo())}");
            Console.ReadKey();

            Console.WriteLine("\nCombinação");
            Console.Write("Digite o valor de n: ");
            MinhaCombinacao.N = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de p: ");
            MinhaCombinacao.P = int.Parse(Console.ReadLine());
            Console.WriteLine($"C(n,p) = {MinhaCombinacao.Calcular(new Calculo())}");
            Console.ReadKey();
        }
    }
}
