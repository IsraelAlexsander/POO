using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    internal class Contratados : Professores
    {
        public string DataAdimissao { get; set; }
        public override void MostrarDados()
        {
            Console.WriteLine($"\n{Nome} - Desciplina: {Disciplina}");
            Console.WriteLine($"Data de Nascimento: {DataNascimento}");
            Console.WriteLine($"Adimissão: {DataAdimissao}");

            Console.ReadKey();
        }

        public override void MostrarDiaAniversario()
        {
            base.MostrarDiaAniversario();

            int MesNascimento;

            MesNascimento = int.Parse(DataNascimento.Substring(3,4));

            Mes MesAniversario;

            MesAniversario = Mes.Janeiro;
            MesAniversario += MesNascimento - 1;

            Console.WriteLine($"O Mês De Seu Aniversário é {MesAniversario}");
        }
    }
}
