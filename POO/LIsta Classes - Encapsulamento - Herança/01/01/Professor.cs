using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class Professor : Funcionario
    {
        public string AreaAtuacao { get; set; }        

        public override void LerDados()
        {
            Console.WriteLine("\nCadastro de Professor\n");

            base.LerDados();

            Console.Write("Área de Atuação: ");
            AreaAtuacao = Console.ReadLine();
        }

        public override void MostrarDados()
        {
            base.MostrarDados();
            Console.WriteLine($"Área de Atuação: {AreaAtuacao}");
        }
    }
}
