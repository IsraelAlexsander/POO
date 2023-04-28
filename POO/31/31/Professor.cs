using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31
{
    internal class Professor
    {
        public string Nome { get; set; }
        public string Disciplina { get; set; }

        public Professor()
        {
            Nome = string.Empty;
            Disciplina = string.Empty;
        }

        public Professor(string pNome, string pDisciplina)
        {
            Nome = pNome;
            Disciplina = pDisciplina;
        }

        public Professor lerDados()
        {
            Console.Write("Nome do professor: ");
            this.Nome = Console.ReadLine();

            Console.Write("Disciplina: ");
            this.Disciplina = Console.ReadLine();

            return this;
        }

        public void MostrarDados(Professor x)
        {
            Console.Clear();
            Console.WriteLine($"Professor {x.Nome} - Disciplina: {x.Disciplina}");
            Console.ReadKey();
        }
    }
}
