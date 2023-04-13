using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public double Salario { get; set; }
        public virtual void LerDados()
        {
            Console.WriteLine("Digite");

            Console.Write("Nome: ");
            Nome = Console.ReadLine();

            Console.Write("Matricula: ");
            Matricula = Console.ReadLine();

            Console.Write("Salário: ");
            Salario = double.Parse(Console.ReadLine());
        }
        public virtual void MostrarDados()
        {
            Console.WriteLine($"{Nome} - {Matricula}");
            Console.WriteLine($"Salário: R$ {Salario}");            
        }
    }
}
