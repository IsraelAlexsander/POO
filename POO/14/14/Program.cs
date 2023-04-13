using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    abstract class OperacaoMatematica
    {
        public abstract double Calcular(double x, double y);
    }

    class Soma : OperacaoMatematica
    {
        public override double Calcular(double x, double y)
        {
            return (double)x + y;
        }
    }

    class Subtracao : OperacaoMatematica
    {
        public override double Calcular(double x, double y)
        {
            return (double)x - y;
        }
    }

    class Multiplicacao : OperacaoMatematica
    {
        public override double Calcular(double x, double y)
        {
            return (double)x * y;
        }
    }

    class Divisao : OperacaoMatematica
    {
        public override double Calcular(double x, double y)
        {
            return (double)x / y;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            double resultado;

            Console.WriteLine("Digite o valor");
            Console.Write("X: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            y = double.Parse(Console.ReadLine());

            resultado = calculaOperacao(new Soma(), x, y);
            Console.WriteLine($"\nSoma = {resultado}");

            resultado = calculaOperacao(new Subtracao(), x, y);
            Console.WriteLine($"\nSubtração: {resultado}");

            resultado = calculaOperacao(new Multiplicacao(), x, y);
            Console.WriteLine($"\nMultiplicação: {resultado}");

            resultado = calculaOperacao(new Divisao(), x, y);
            Console.WriteLine($"\nDivisão: {resultado}");

            Console.ReadKey();
        }

        static double calculaOperacao(OperacaoMatematica O, double x, double y) // Classe em comum entre as operações
        {
            return O.Calcular(x, y);
        }
    }
}
