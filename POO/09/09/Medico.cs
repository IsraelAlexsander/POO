using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    internal class Medico : Profissional
    {
        public string crm { get; set; }

        public new void lerDados()
        {
            base.lerDados();

            Console.Write("CRM: ");
            crm = Console.ReadLine();
        }

        public new void mostrarDados()
        {
            base.mostrarDados();

            Console.WriteLine($"CRM: {crm}");
        }

    }
}
