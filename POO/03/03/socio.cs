using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class socio
    {
        public int nrCota { get; set; }
        public string nomeSocio { get; set; }
        public string dataNasc { get; set; }
        public string dataAquisicao { get; set; }

        public void entraDados()
        {
            Console.Clear();

            Console.WriteLine("Cadastro de socio");
            Console.WriteLine("#################\n");

            Console.Write("\nNúmero da cota: ");
            this.nrCota = int.Parse(Console.ReadLine());

            Console.Write("Nome do socio: ");
            this.nomeSocio = Console.ReadLine();

            Console.Write("Data de nascimento: ");
            this.dataNasc = Console.ReadLine();

            Console.Write("Data de aquisição: ");
            this.dataAquisicao = Console.ReadLine();
        }
    }
}
