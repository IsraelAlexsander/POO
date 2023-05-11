using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33   // Tratamendo de Exceções
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Introdução
            //int a, b, c, result;

            //Console.Write("A = ");
            //a = int.Parse(Console.ReadLine());
            //Console.Write("B = ");
            //b = int.Parse(Console.ReadLine());

            //result = 0;

            //try
            //{
            //    if (a % 2 == 0 && b % 2 == 0)
            //    {
            //        result = a / b;
            //    }
            //}
            //catch(DivideByZeroException ex)
            //{
            //    Console.WriteLine("\nERRO ! Divisão por Zero!");
            //    Console.WriteLine(ex.Message);

            //    result = 0;
            //}

            //Console.ReadKey();
            #endregion

            int MesAniversario;
            string NomeMesAniversario;

            Console.WriteLine("Digite o mês do seu aniversário: ");
            MesAniversario = int.Parse(Console.ReadLine());

            NomeMesAniversario = ObterMes(MesAniversario);

            Console.WriteLine($"Você nasceu em {NomeMesAniversario}");

            Console.ReadKey();
        }

        static string ObterMes(int MesAniversario)
        {
            string[] NomeMes = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"};

            try
            {
                return NomeMes[MesAniversario - 1];
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("\nERRO! ");
                Console.WriteLine(e.Message);

                return "Indefinido";
            }
        }
    }
}
