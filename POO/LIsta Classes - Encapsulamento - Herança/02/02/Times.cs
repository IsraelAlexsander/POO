using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Times
    {
        public string Nome { get; set; }
        public string Presidente { get; set; }
        public string Tecnico { get; set; }
        public string DataFuncacao { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }

        public void LerDados()
        {
            Console.Write("Nome: ");
            Nome = Console.ReadLine();

            Console.Write("Presidente: ");
            Presidente = Console.ReadLine();

            Console.Write("Técnico: ");
            Tecnico = Console.ReadLine();

            Console.Write("Data de Fundação: ");
            DataFuncacao = Console.ReadLine();

            Console.Write("Cidade: ");
            Cidade = Console.ReadLine();

            Console.Write("UF: ");
            UF = Console.ReadLine();
        }

        public void MostrarDados()
        {
            Console.WriteLine($"{Nome}");
            Console.WriteLine($"Presidente {Presidente}");
            Console.WriteLine($"Técnico {Tecnico}");
            Console.WriteLine($"Data de Fundação: {DataFuncacao}");
            Console.WriteLine($"Cidade: {Cidade}");
            Console.WriteLine($"UF: {UF}\n");            
        }
    }
}
