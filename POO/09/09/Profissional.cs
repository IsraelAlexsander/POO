using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    internal class Profissional
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public string dataAdimissao { get; set; }
        public int salario { get; set; }

        public void lerDados()
        {
            Console.Write("Nome: ");
            nome = Console.ReadLine();

            Console.Write("CPF: ");
            cpf = Console.ReadLine();

            Console.Write("Data Adimissão: ");
            dataAdimissao = Console.ReadLine();

            Console.Write("Salário: ");
            salario = int.Parse(Console.ReadLine());
        }

        public void mostrarDados()
        {
            Console.WriteLine($"{nome}");
            Console.WriteLine($"CPF: {cpf}");
            Console.WriteLine($"Data Adimissão: {dataAdimissao}");
            Console.WriteLine($"Salário: {salario}");            
        }
    }
}
