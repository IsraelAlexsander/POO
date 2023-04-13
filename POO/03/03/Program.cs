using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<socio> socios = new List<socio>();
            List<dependente> dependentes = new List<dependente>();

            socio s;
            dependente d;

            do
            {
                s = new socio();                

                s.entraDados();

                socios.Add(s);

                Console.Write("O socio possui dependentes? (S/N)");

                if (Console.ReadKey(true).Key == ConsoleKey.S)
                {
                    do
                    {
                        d = new dependente();

                        d.entraDados(s.nrCota);

                        dependentes.Add(d);

                        Console.Write("Deseja cadastrar outro dependente? (S/N)");
                    } while (Console.ReadKey(true).Key == ConsoleKey.S);
                }

                Console.Write("\nDeseja cadastrar outro socio? (S/N)");
            } while (Console.ReadKey(true).Key == ConsoleKey.S);

            //Listagem geral

            Console.Clear();

            foreach (socio x in socios)
            {
                Console.WriteLine($"\n{x.nrCota} - {x.nomeSocio}");
                Console.WriteLine($"Nascimento: {x.dataNasc}");
                Console.WriteLine($"Aquisição: {x.dataAquisicao}");

                foreach (dependente y in dependentes)
                {
                    if (y.nrCota == x.nrCota)
                    {
                        Console.WriteLine($"    => {y.nomeDependente}");
                    }
                }
            }

            Console.ReadKey();

            int cota;

            Console.Write("Digite uma cota para exclusão: ");
            cota = int.Parse(Console.ReadLine());

            foreach(socio x in socios)
            {
                if (x.nrCota == cota)
                    s = x;
            }

            socios.Remove(s);

            List<dependente> cotasExcluir = new List<dependente>();

            foreach (dependente y in dependentes)
            {
                if (y.nrCota == cota)
                    cotasExcluir.Add(y);
            }      
            
            foreach (dependente z in cotasExcluir)
            {
                dependentes.Remove(z);
            }
        }
    }
}
