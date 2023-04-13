using System;
using System.Collections;
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
            ArrayList Cadastro = new ArrayList();
            int opc;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Cadastro de Funcionário");
                Console.WriteLine("2 - Listar Funcionários");
                Console.WriteLine("3 - Sair");
                Console.Write("Opção: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        // Cadastrar Funcionário
                        Console.Clear();

                        Console.WriteLine("Tipo de funcionário:\t1 - Administrador\t2 - Vendedor");
                        Console.Write("Tipo: ");
                        int TipoFunc = int.Parse(Console.ReadLine());

                        Console.Clear();
                        if (TipoFunc == 1)
                        {
                            Administrador Admin = new Administrador();
                            Admin.LerDados();
                            Cadastro.Add(Admin);

                            Console.WriteLine("\nFuncionário Cadastrado");
                            Thread.Sleep(1000);
                        }    
                        else if (TipoFunc == 2)
                        {
                            Vendedor Vend = new Vendedor();
                            Vend.LerDados();
                            Cadastro.Add(Vend);
                            Console.WriteLine("\nFuncionário Cadastrado");
                            Thread.Sleep(1000);
                        }
                        else
                        {
                            Console.WriteLine("Opção Invalida!");
                            Thread.Sleep(1000);
                        }

                        break;
                    case 2:
                        // Listar Funcionários
                        Console.Clear();

                        Console.WriteLine("Lista de funcionários\n");

                        if (Cadastro.Count == 0)
                            Console.WriteLine("Lista vazia");
                        else
                            foreach (Funcionario F in Cadastro)
                                F.MostrarDados();
                        Console.ReadKey();

                        break;
                    case 3:
                        // Sair
                        Console.Clear();

                        Console.WriteLine("Saindo...");
                        Thread.Sleep(1000);

                        break;

                    default:
                        Console.WriteLine("Opção Invalida");
                        Thread.Sleep(1000);
                        break;
                }

            } while (opc != 3);
        }
    }
}
