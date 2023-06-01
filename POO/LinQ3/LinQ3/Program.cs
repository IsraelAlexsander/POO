using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ3
{
    class Voto
    {
        public int NrCandidato { get; set; }
        public int Eleitor { get; set; }
        public string UF { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Voto[] VetorVotos = new Voto[8];
            Voto MeuVoto;

            MeuVoto = new Voto
            {
                NrCandidato = 123,
                Eleitor = 464604,
                UF = "MG"                
            };

            VetorVotos[0] = MeuVoto;

            MeuVoto = new Voto
            {
                NrCandidato = 123,
                Eleitor = 495009,
                UF = "MG"
            };

            VetorVotos[1] = MeuVoto;

            MeuVoto = new Voto
            {
                NrCandidato = 456,
                Eleitor = 935088,
                UF = "ES"
            };

            VetorVotos[2] = MeuVoto;

            MeuVoto = new Voto
            {
                NrCandidato = 123,
                Eleitor = 126790,
                UF = "MG"
            };

            VetorVotos[3] = MeuVoto;

            MeuVoto = new Voto
            {
                NrCandidato = 456,
                Eleitor = 101919,
                UF = "MG"
            };

            VetorVotos[4] = MeuVoto;

            MeuVoto = new Voto
            {
                NrCandidato = 456,
                Eleitor = 345678,
                UF = "ES"
            };

            VetorVotos[5] = MeuVoto;

            MeuVoto = new Voto
            {
                NrCandidato = 123,
                Eleitor = 899887,
                UF = "ES"
            };

            VetorVotos[6] = MeuVoto;

            MeuVoto = new Voto
            {
                NrCandidato = 123,
                Eleitor = 986532,
                UF = "MG"
            };

            VetorVotos[7] = MeuVoto;


            Console.WriteLine("Listagem geral dos votos");

            Console.WriteLine();

            foreach (Voto x in VetorVotos)
            {
                Console.WriteLine($"Candidato Nrº. {x.NrCandidato} - Voto do Eleitor {x.Eleitor} ({x.UF})");
            }

            Console.ReadKey();
            Console.Clear();

            // Consultas LINQ 

            var votosMG = from x in VetorVotos
                          where x.UF == "MG"
                          orderby x.Eleitor
                          select x;

            Console.WriteLine("Listagem geral de votos de Minas Gerais"); 
            foreach (Voto v in votosMG)
            {
                Console.WriteLine($"\tCandidato Nrº {v.NrCandidato} - Voto do Eleitor {v.Eleitor}");
            }

            Console.ReadKey();
            Console.Clear();

            var votosUF = from x in VetorVotos
                          orderby x.UF
                          group x by x.UF;

            Console.WriteLine("Listagem de votos por Unidade Federativa\n");
            foreach (var Grupo in votosUF)
            {
                Console.WriteLine($"Votos de origem em {Grupo.Key} ({Grupo.Count()})");                
                foreach(var x in Grupo)
                {
                    Console.WriteLine($"\t=> Eleitor {x.Eleitor} votou no candidato {x.NrCandidato}");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
            Console.Clear();

            var contagemVotos = from x in VetorVotos
                                orderby x.NrCandidato
                                group x by x.NrCandidato;

            Console.WriteLine("Listagem de votos por candidato\n");

            foreach (var x in contagemVotos)
            {
                Console.WriteLine($"Votos no candidato: {x.Key} ({x.Count()})");
                foreach (var v in x)
                {
                    Console.WriteLine($"\t=>{v.Eleitor}");
                }

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
