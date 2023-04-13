using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03
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
                    Console.WriteLine("\nDIGITE UM NÚMERO");
                    Thread.Sleep(1000);
                    goto Menu;
                }

                switch (opcao)
                {
                    case 1:
                        // Inserir Times

                        Console.Clear();

                        Console.Write("Tipo de Time\n1 - Profissional\t2 - Várzea\nOpção: ");                        

                        try
                        {
                            int Tipo = int.Parse(Console.ReadLine());


                            if (Tipo == 1)
                            {
                                Inserir(new Profissional(), MeusDados);
                            }

                            else if (Tipo == 2)
                            {
                                Inserir(new Varzea(), MeusDados);
                            }

                            else
                            {
                                Console.WriteLine("Opção Invalida");
                            }                            

                            Console.WriteLine("\nTime inserido");

                            Thread.Sleep(1000);
                        }
                        catch
                        {
                            Console.WriteLine("\nDIGITE UM NÚMERO");
                            Thread.Sleep(1000);
                            goto Menu;
                        }

                        break;
                    case 2:
                        // Listar Times

                        Console.Clear();

                        Listar(MeusDados);

                        Console.WriteLine("\nAperte qualquer tecla para sair...");
                        Console.ReadKey();

                        break;
                    default:

                        Console.WriteLine("Número fora das opções");
                        Thread.Sleep(1000);

                        break;
                }
            } while (opcao != 3);
        }
        static void Inserir(Times T, Dados MeusDados)
        {
            Console.Clear();
            T.LerDados();
            MeusDados.InserirTime(T);
        }

        static void Listar(Dados MeusDados)
        {
            Console.Clear();
            Console.WriteLine("Times Cadastrados\n\n");
            MeusDados.ListarTimes();
        }
    }
}