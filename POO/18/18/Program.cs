using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AumentoSalarial MinhaOperacao = new AumentoSalarial();

            Funcionario MeuFunc;

            ArrayList Cadastro = new ArrayList();

            do
            {
                Console.Clear();

                MeuFunc = new Funcionario();

                Console.Write("Nome do Funcionario: ");
                MeuFunc.Nome = Console.ReadLine();

                Console.Write("Salário (R$): ");
                MeuFunc.Salario = double.Parse(Console.ReadLine());

                if (MeuFunc.Salario <= 2000)
                    MinhaOperacao.SetaEstrategia(new AumentoN1());
                else if (MeuFunc.Salario > 8000)
                    MinhaOperacao.SetaEstrategia(new AumentoN3());
                else
                    MinhaOperacao.SetaEstrategia(new AumentoN2());

                MeuFunc.SalarioNovo = MinhaOperacao.ExecuteEstrategia(MeuFunc.Salario);

                Cadastro.Add(MeuFunc);

                Console.WriteLine("\nNovo Registro? (ESC cancela...)");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            Console.Clear();

            foreach(Funcionario x in Cadastro)
            {
                Console.WriteLine($"{x.Nome} - R$ {x.SalarioNovo:F2}\n");
            }

            Console.ReadKey();
        }
    }
}
