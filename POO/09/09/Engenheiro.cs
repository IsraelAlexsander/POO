using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    internal class Engenheiro : Medico
    {
        public string crea { get; set; }

        public new void lerDados()
        {
            base.lerDados();

            Console.Write("CREA: ");
            crea = Console.ReadLine();
        }

        public new void mostrarDados()
        {
            base.mostrarDados();

            Console.WriteLine($"CREA: {crea}\n");
        }
    }
}
