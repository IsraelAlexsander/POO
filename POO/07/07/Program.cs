using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    class A
    {
        public A ()
        {
            Console.WriteLine("Construtor da calsse A1\n");
            Console.ReadKey();

        }

        public A (string titulo)
        {
            Console.WriteLine($"Construtor da classe A com o Título {titulo}\n");
            Console.ReadKey();
        }
    }

    class B : A
    {
        public B ()
        {
            Console.WriteLine("Construtor da classe B");
            Console.ReadKey();
        }

        public B (string titulo) : base (titulo)    //Comando que referência o construtor do metodo pai
        {
            Console.WriteLine($"Construtor da classe B com o Título {titulo}");
            Console.ReadKey();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A meuA = new A ();

            B meuB = new B ("EXEMPLO");
            

        }
    }
}
