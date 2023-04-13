using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25 // DELEGATES e EXPRESSÕES LAMBDA
{
    public delegate void MeuDelegateA();
    public delegate void MeuDelegateB(ArrayList Lista);
    public delegate int Calcula(int x, int y);
    public delegate double CalculaDelta(double a, double b, double c);
    internal class Program
    {
        static void Main(string[] args)
        {            
            MeuDelegateA MostraA = new MeuDelegateA(FuncTesteA);

            MostraA();
            Console.Clear();

            MeuDelegateB MostraB = new MeuDelegateB(FuncTesteB);

            ArrayList Carros = new ArrayList();

            Carros.Add("Fiat Stilo");
            Carros.Add("Toyota Corolla");
            Carros.Add("Volkswagen Gol");
            Carros.Add("Mitsubishi Pajero");
            Carros.Add("Chevrolet Captiva");

            MostraB(Carros);
            Console.Clear();

            Calcula Somar = new Calcula(Soma);
            
            Console.WriteLine($"4 + 6 = {Somar(4, 6)}"); 
            Console.ReadKey();
            Console.Clear();

            
            CalculaDelta Delta = new CalculaDelta((double a, double b, double c) => b * b - 4 * a * c); // Expressão lambda

            Console.WriteLine($"Valor do dalta: {Delta(1, 3, -4)}");
            Console.ReadKey();
            Console.Clear();

            int[] Numeros = { 25, 41, 11, 37, 9, 82, 64, 71, 12 };

            foreach(int x in Numeros)
            {
                Console.Write($"{x,6}");
            }
            Console.ReadKey();

            int QtedPares = Numeros.Count(n => n % 2 == 0);

            Console.WriteLine($"\n\nTotal de Pares: {QtedPares}");
            Console.ReadKey();
        }
        static void FuncTesteA()
        { 
                Console.WriteLine("Executando FuncTesteA");
                Console.ReadKey();
        }

        static void FuncTesteB(ArrayList Lista)
        {
            foreach(var x in Lista)
            {
                Console.WriteLine($"{x}");
            }
            Console.ReadKey();
        }

        static int Soma(int a, int b)
        {
            return a + b;
        }
    }
}
