using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string CarteiraDeTrabalho { get; set; }
        public int Salario { get; set; }          
                

        public virtual void LerDados()
        {            
            Console.Write("Nome: ");
            Nome = Console.ReadLine();

            Console.Write("Endereço: ");
            Endereco = Console.ReadLine();

            Console.Write("Telefone: ");
            Telefone = Console.ReadLine();

            Console.Write("Carteira de Trabalho: ");
            CarteiraDeTrabalho = Console.ReadLine();

            Console.Write("Salario: ");
            Salario = int.Parse(Console.ReadLine());            
        }

        public virtual void MostrarDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Endereço: {Endereco}");
            Console.WriteLine($"Telefone: {Telefone}");
            Console.WriteLine($"Carteira de Trabalho: {CarteiraDeTrabalho}");
            Console.WriteLine($"Salário: {Salario}");
        }        
    }
}
