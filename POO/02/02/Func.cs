using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Func
    {
		private string _matricula;

		public string matricula
		{
			get { return _matricula; }
			set { _matricula = value; }
		}

		public string nome { get; set; }

		public double salario { get; set; }

		public void lerDados()
		{
            Console.Write($"Matricula do funcionario: ");
            this.matricula = Console.ReadLine();

            Console.WriteLine($"Nome funcionário: ");
            this.nome = Console.ReadLine();

            Console.Write($"Salário; ");
            this.salario = double.Parse(Console.ReadLine());
        }

	}
}
