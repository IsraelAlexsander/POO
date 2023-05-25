using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] VetorIntA = { 98, 45, 67, 23, 8, 90, 58, 30, 26, 72 };
            int[] VetorIntB = { 35, 48, 97, 65, 17, 49, 93, 50, 32, 71 };

            string[] VetorStringA = { "FIAT", "cHevrOlEt", "ToyOTa", "mItsuBIShi", "VolKswAgEn" };
            string[] VetorStringB = { "Banana", "Abacate", "Melancia", "Amora", "Caju", "Abacaxi", "Maça" };
            
            //var Consulta = from Valor in VetorIntA
            //               where Valor > 50
            //               orderby Valor
            //               select Valor;

            //foreach(int x in Consulta)
            //{
            //    Console.Write($"{x,7}");
            //}

            //Console.WriteLine($"\n\nQuantidade de valores > 50: {Consulta.Count()}");

            //var Compara = from Valor1 in VetorIntA
            //              from Valor2 in VetorIntB
            //              where Valor1 <= Valor2
            //              select new {Valor1, Valor2};  // Tipo anonimo (Objetos inicializados)


            //foreach (var x  in Compara)
            //{
            //    Console.WriteLine($"{x.Valor1} é menor ou igual a {x.Valor2}");
            //}

            //var Palavras = from Valor in VetorStringA
            //               select new { Maiusculas = Valor.ToUpper(), Minusculas = Valor.ToLower() };

            //foreach(var x in Palavras)
            //{
            //    Console.WriteLine($"{x.Minusculas} - {x.Minusculas}");
            //}

            var ConsultaFrutas = from Fruta in VetorStringB
                                 orderby Fruta
                                 group Fruta by Fruta[0];

            foreach (var GrupoFruta in ConsultaFrutas)
            {
                Console.WriteLine($"\nFrutas que começam com a letra {GrupoFruta.Key}");
                foreach (var F in GrupoFruta)
                {
                    Console.WriteLine($"\t==> {F}");
                }
            }

            Console.ReadKey();
        }
    }
}
