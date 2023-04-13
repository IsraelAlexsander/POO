using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _23
{
    internal class Program
    {
        class Candidato
        {
            public string Nome { get; set; }
            public double PretencaoSalarial { get; set; }
        }
        class Contratacao       //Fachada
        {
            private ExameMedico ExameMedicoCandidado = new ExameMedico();
            private ExamePsicotecnico ExamePsicotecnicoCandidato = new ExamePsicotecnico();
            private ProvaProtica ProvaProticaCandidato = new ProvaProtica();
            private PretencaoSalarial PretencaoSalarialCandidato = new PretencaoSalarial();

            public bool PodeContratar(Candidato x)
            {
                bool Alturizado = true;

                if (!ExameMedicoCandidado.Apto())
                    Alturizado = false;
                if (!ExamePsicotecnicoCandidato.Apto())
                    Alturizado = false;
                if (!ProvaProticaCandidato.Aprovado())
                    Alturizado = false;
                if (!PretencaoSalarialCandidato.DentroDaFaixa(x))
                    Alturizado = false;

                return Alturizado;
            }
        }

        class ExameMedico
        {
            public bool Apto()
            {
                Console.WriteLine("\tCondições Físicas Normais... OK!");

                return true;
            }
        }
        class ExamePsicotecnico
        {
            public bool Apto()
            {
                Console.WriteLine("\tCondições Mentais Normais... OK!");

                return true;
            }
        }
        class ProvaProtica
        {
            public bool Aprovado()
            {
                Console.WriteLine("\tProva Prática: Aprovado");

                return true;
            }
        }
        class PretencaoSalarial
        {
            public bool DentroDaFaixa(Candidato xCandidato)
            {
                if(xCandidato.PretencaoSalarial <= 8000)
                {
                    Console.WriteLine("\tSalário Pretendido: Dentro da Faixa!");
                    return true;
                }
                else
                {
                    Console.WriteLine("\tSalário Pretendido: Fora da Faixa!");
                    return false;
                }
            }
        }

        static void Main(string[] args)
        {
            Contratacao MinhaContratacao = new Contratacao();
            Candidato MeuCandidato = new Candidato();

            Console.Write("Nome do Candidato: ");
            MeuCandidato.Nome = Console.ReadLine();
            Console.Write("Pretenção Salarial: ");
            MeuCandidato.PretencaoSalarial = double.Parse(Console.ReadLine());

            bool Contratar = MinhaContratacao.PodeContratar(MeuCandidato);

            Console.WriteLine($"\n\nA Contratação do Funcionário {MeuCandidato.Nome} {(Contratar?"Foi":"Não foi")} Aprivutorizada");
            Console.ReadKey();
        }
    }
}
