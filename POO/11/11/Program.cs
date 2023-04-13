using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Incremento    // sealed impede que a classe seja herdada
    {
        protected static int x = 0;

        public Incremento ()
        {
            x++;
        }
    }

    class Aluno : Incremento
    {
        public int id { get; set; }
        public string nome { get; set; }

        public Aluno ()
        {
            id = Incremento.x;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno meuAluno;

            ArrayList Cadastro = new ArrayList();

            meuAluno = new Aluno();
            meuAluno.nome = "Israel";
            Cadastro.Add(meuAluno);

            meuAluno = new Aluno();
            meuAluno.nome = "Denize";
            Cadastro.Add(meuAluno);

            meuAluno = new Aluno();
            meuAluno.nome = "Gustavo";
            Cadastro.Add(meuAluno);

            foreach(Aluno x in Cadastro)
            {
                Console.WriteLine($"ID: {x.id} - {x.nome}");                
            }

            Console.ReadKey();
        }
    }
}
