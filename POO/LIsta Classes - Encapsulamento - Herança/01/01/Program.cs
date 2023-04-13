using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            Professor MeuProfessor;
            Administrador MeuAdministrador;

            Administrador[] Administradores = new Administrador[100];
            Professor[] Professores = new Professor[100];

            int nProfessores = 0;
            int nAdministradores = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Sistema de Academia de Ginastica\n");

                Console.WriteLine("1 - Cadastrar Funcionário");
                Console.WriteLine("2 - Listar Funcionários");
                Console.WriteLine("3 - Sair\n");
                Console.Write("Opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Cadastro:
                        Console.Clear();                        

                        Console.Write("O Funcionário é:\t(A) Administrador\t(P) Professor\nTipo: ");
                        char Tipo = char.Parse(Console.ReadLine().ToUpper());

                        if (Tipo == 'A')
                        {
                            MeuAdministrador = new Administrador();
                            MeuAdministrador.LerDados();
                            Administradores[nAdministradores] = MeuAdministrador;
                            nAdministradores++;
                        }
                        else if (Tipo == 'P')
                        {
                            MeuProfessor = new Professor();
                            MeuProfessor.LerDados();
                            Professores[nProfessores] = MeuProfessor;
                            nProfessores++;
                        }  
                        else
                        {
                            Console.WriteLine("Tipo de Funcionário invalido!");
                            goto Cadastro;
                        }

                        Console.WriteLine("\n\nCadastro Realizado");
                        Thread.Sleep(1000);

                        break;

                    case 2:
                        Console.Clear();

                        Console.WriteLine("Lista de Funcionários\n\nProfessores\n");

                        for (int i = 0; i < nProfessores; i++)
                        {
                            Professores[i].MostrarDados();
                            Console.WriteLine();
                        }

                        Console.WriteLine("\nAdministradores\n");
                        for (int i = 0;i < nAdministradores; i++)
                        {
                            Administradores[i].MostrarDados();
                            Console.WriteLine();
                        }

                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();

                        Console.WriteLine("Saindo do Sistema");
                        Thread.Sleep(1000);
                        break;
                    default:
                        Console.WriteLine("Opção Invalida");
                        Thread.Sleep(1000);
                        break;

                }                

            } while (opcao != 3);
        }        
    }
}
