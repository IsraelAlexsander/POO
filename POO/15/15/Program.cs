using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public override string ToString()
        {
            return $"{Nome} tem {Idade} anos!";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno MeuAluno = new Aluno();

            MeuAluno.Nome = "Israel Alexsander";
            MeuAluno.Idade = 22;

            Console.WriteLine(MeuAluno.ToString()); //ToString é um metodo virtual

            Console.ReadKey();
        }
    }
}
