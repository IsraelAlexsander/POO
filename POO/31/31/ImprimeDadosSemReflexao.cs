using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _31
{
    internal class ImprimeDadosSemReflexao
    {
        public void ImprimirAluno(Aluno x)
        {
            Console.Clear();

            Console.WriteLine($"{x.Nome} ({x.MatAluno})");

            Console.ReadKey();
        }

        public void ImprimirDisciplina(Disciplina x)
        {
            Console.Clear();

            Console.WriteLine($"{x.NomeDisc} ({x.CodDisc})");

            Console.ReadKey();
        }

        public void ImprimirMatricula(Matricula x)
        {
            Console.Clear();

            Console.WriteLine($"Matrícula {x.NumeroMat}");
            Console.WriteLine($"Aluno: {x.MatAluno} - Disciplina: {x.CodDisc}");
            Console.WriteLine($"Data da Matrícula: {x.DataMat}");

            Console.ReadKey();
        }
    }
}
