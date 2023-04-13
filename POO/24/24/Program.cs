using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operacao MinhaOperacao = new Operacao();

            int N1, N2;
            int Resultado;

            Console.Write("N1: ");
            N1 = int.Parse(Console.ReadLine());
            Console.Write("N2: ");
            N2 = int.Parse(Console.ReadLine());

            MinhaOperacao.SetEstrategia(new Soma());
            Resultado = MinhaOperacao.ExecutaOperacao(N1, N2);
            Console.WriteLine($"\n{N1} + {N2} = {Resultado}\n\n");

            MinhaOperacao.SetEstrategia(new Subtracao());
            Resultado = MinhaOperacao.ExecutaOperacao(N1, N2);
            Console.WriteLine($"{N1} - {N2} = {Resultado}\n\n");

            MinhaOperacao.SetEstrategia(new Multiplicacao());
            Resultado = MinhaOperacao.ExecutaOperacao(N1, N2);
            Console.WriteLine($"{N1} * {N2} = {Resultado}\n\n");

            MinhaOperacao.SetEstrategia(new Divisao());
            Resultado = MinhaOperacao.ExecutaOperacao(N1, N2);
            Console.WriteLine($"{N1} / {N2} = {Resultado} \n\n");
            Console.ReadKey();
        }
    }
}
