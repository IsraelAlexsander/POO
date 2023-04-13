using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    internal class Fisica : Pessoa
    {
        public string cpf { get; set; }
        public string sexo { get; set; }

        public new void lerDados()
        {
            base.lerDados();

            Console.Write("CPF: ");
            this.cpf = Console.ReadLine();

            Console.Write("Sexo: ");
            this.sexo = Console.ReadLine();
        }
    }
}
