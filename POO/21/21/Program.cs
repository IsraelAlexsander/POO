using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class Numero
    {
        public int Num { get; set; }
        public int Calcula(IPrimo x)
        {
            return x.AchaPrimo(Num);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int Prox;
            int Ant;

            Numero x = new Numero();

            Console.Write("Digite um número: ");
            x.Num = int.Parse(Console.ReadLine());

            Prox = x.Calcula(new PrimoAcima());
            Ant = x.Calcula(new PrimoAbaixo());

            Console.WriteLine($"\nO próximo primo acima de {x.Num} é o {Prox}");
            if (Ant != 0)
                Console.WriteLine($"O primo anterior a {x.Num} é o {Ant}");

            Console.ReadKey();
        }
    }
}
