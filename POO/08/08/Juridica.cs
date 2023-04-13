using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    internal class Juridica : Pessoa
    {
        public string cnpj { get; set; }

        public new void lerDados()
        {
            base.lerDados();

            Console.Write("CNPJ: ");
            this.cnpj = Console.ReadLine();
        }
    }
}
