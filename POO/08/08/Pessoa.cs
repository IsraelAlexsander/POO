using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    internal class Pessoa
    {
        public string nome { get; set; }
        public void lerDados()
        {
            Console.Write("\nNome: ");
            this.nome = Console.ReadLine();
        }
    }
}
