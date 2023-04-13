using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Administrador : Funcionario
    {
        public string NomeSetor { get; set; }
        public override void LerDados()
        {
            Console.WriteLine("Cadastro de Administrador");

            base.LerDados();

            Console.Write("Nome do Setor: ");
            NomeSetor = Console.ReadLine();
        }
        public override void MostrarDados()
        {
            Console.WriteLine("Administrador");
            base.MostrarDados();
            Console.WriteLine($"Setor: {NomeSetor}\n");            
        }
    }
}
