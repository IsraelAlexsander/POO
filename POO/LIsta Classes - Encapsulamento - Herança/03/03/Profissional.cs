using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Profissional : Times
    {
        public string Patrocinio { get; set; }
        public override void LerDados()
        {
            Console.WriteLine("Cadastro Time Profissional\n");

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

            Console.Write("Patrocinador: ");
            Patrocinio = Console.ReadLine();
        }

        public override void MostrarDados()
        {
            Console.WriteLine($"{Nome}\tProfissional");
            Console.WriteLine($"Presidente {Presidente}");
            Console.WriteLine($"Técnico {Tecnico}");
            Console.WriteLine($"Data de Fundação: {DataFuncacao}");
            Console.WriteLine($"Cidade: {Cidade}");
            Console.WriteLine($"UF: {UF}");
            Console.WriteLine($"Patrocinador: {Patrocinio}\n");
        }
    }
}
