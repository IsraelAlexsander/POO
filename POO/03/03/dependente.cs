using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class dependente
    {
        public int nrCota { get; set; }
        public string nomeDependente { get; set; }
        public string dataNasc { get; set; }

        public void entraDados(int cota)
        {
            this.nrCota = cota;

            Console.Write("\nNome do dependente: ");
            this.nomeDependente = Console.ReadLine();

            Console.Write("Data nascimento: ");
            this.dataNasc = Console.ReadLine();
        }
    }
}
