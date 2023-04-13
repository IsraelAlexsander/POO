using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            Dados MeusDados = new Dados();            

            do
            {
                Menu:

                Console.Clear();

                Console.WriteLine("1 - Incluir Time");
                Console.WriteLine("2 - Listar Times");
                Console.WriteLine("3 - Sair\n");

                Console.Write("Opção: ");

                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Opção Invalida!");
                    Thread.Sleep(1000);
                    goto Menu;
                }

                switch (opcao)
                {
                    case 1:
                        // Inserir Times
                        
                        Console.Clear();
                        
                        Inserir(new Times(), MeusDados);

                        Console.WriteLine("Time inserido");

                        Thread.Sleep(1000);

                        break;
                    case 2:
                        // Listar Times

                        Console.Clear();

                        Listar(MeusDados);

                        Console.ReadKey();

                        break;
                }                                
            } while (opcao != 3);
        }     
        static void Inserir(Times T, Dados MeusDados)
        {
            T.LerDados();
            MeusDados.InserirTime(T);
        }

        static void Listar(Dados MeusDados)
        {
            MeusDados.ListarTimes();
        }
    }
}
