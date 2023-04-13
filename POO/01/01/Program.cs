using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Func
    {
        public int Matricula;
        public string Nome;
        public double Salario;

        public void LerDados()
        {
            Console.Write("Matricula do funcionário: ");
            Matricula = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            Nome = Console.ReadLine();

            Console.Write("Salário: ");
            Salario = double.Parse(Console.ReadLine());            
        }

        public void Imprimir()
        {
            Console.WriteLine($"{Matricula} - {Nome}");
            Console.WriteLine($"Salário: {Salario:F2}\n");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Func X = new Func();    //Instância

            //X.LerDados();

            //Console.Clear();

            //X.Imprimir();

            //Console.ReadKey();

            Func[] Cad = new Func[3];

            for(int i = 0; i < Cad.Length; i++)
            {
                Func x = new Func();

                x.LerDados();

                Cad[i] = x;

                Console.WriteLine();
            }

            Console.Clear();

            foreach (Func X in Cad)
            {
                X.Imprimir();
            }

            Console.ReadKey();
        }
    }
}
