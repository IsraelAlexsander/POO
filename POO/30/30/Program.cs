using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30
{
    class Aluno
    {
        public string Matricula { get; set; }
        public string Nome { get; set; }

    }

    class CadastroAlunos
    {
        private Aluno[] Cadastro = new Aluno[3];
        
        public Aluno this[int i]    // Indexador
        {
            get 
            {
                return Cadastro[i];
            }
            set 
            {
                Cadastro[i] = value; 
            }
        }
    }

    internal class Program  // Indexadores
    {
        static void Main(string[] args)
        {
            CadastroAlunos MeuCadastro = new CadastroAlunos();

            Aluno MeuAluno;

            for (int i = 0; i < 3; i++)
            {
                MeuAluno = new Aluno();

                Console.Write("Matrícula do Aluno: ");
                MeuAluno.Matricula = Console.ReadLine();

                Console.Write("Nome: ");
                MeuAluno.Nome = Console.ReadLine();

                MeuCadastro[i] = MeuAluno;
                Console.WriteLine("\n");
            }
            Console.Clear();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{MeuCadastro[i].Nome} - {MeuCadastro[i].Matricula}");
            }

            Console.ReadKey();

        }
    }
}
