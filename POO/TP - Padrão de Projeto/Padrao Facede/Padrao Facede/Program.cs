using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padrao_Facede
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aprovacao MinhaAprovacao = new Aprovacao();

            do
            {
                Console.Clear();
                Console.Write("Nome do Aluno: ");
                string Nome = Console.ReadLine();

                bool Participar = MinhaAprovacao.PodeParticipar();

                Console.WriteLine($"\n\nO Aluno {Nome} {(Participar?"pode" : "não pode")} participar como pesquisador");

                Console.WriteLine("Avaliar outro aluno? (ESQ para sair) ");

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
