using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{

    internal class Program
    {
        class Venda
        {
            public static double totalVendas { get; private set; }
            public static double qtdeVendas { get; private set; }

            public Venda (double valor)
            {
                totalVendas += valor;
                qtdeVendas++;
            }

        }

        static void Main(string[] args)
        {
            double valor;

            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Valor da venda: ");
                valor = double.Parse(Console.ReadLine());

                Venda x = new Venda(valor);
            }

            Console.WriteLine($"Total vendido: R$ {Venda.totalVendas:F2}");
            Console.WriteLine($"Itens vendidos: {Venda.qtdeVendas}");

            Console.ReadKey();
        }
    }
}
