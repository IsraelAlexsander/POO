using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Vendedor : Funcionario
    {
        public double PercentualComissao { get; set; }
        public override void LerDados()
        {
            Console.WriteLine("Cadastro Vendedor");

            base.LerDados();

            Console.Write("Percentual de Comissão: ");
            PercentualComissao = double.Parse(Console.ReadLine());
        }
        public override void MostrarDados()
        {
            Console.WriteLine("Vendedor");
            base.MostrarDados();
            Console.WriteLine($"Percentual de Comissão: {PercentualComissao}\n");
        }
    }
}
