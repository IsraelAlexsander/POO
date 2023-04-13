using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Agenda Agenda = new Agenda();

            DateTime DataHora1, DataHora2;
            string Data;
            string Hora;

            Console.Write("Data 1 :");
            Data = Console.ReadLine();

            Console.Write("Hora 1: ");
            Hora = Console.ReadLine();

            DataHora1 = Agenda.InicializaDataHora(Data, Hora);

            Console.Write("Data 2 :");
            Data = Console.ReadLine();

            Console.Write("Hora 2: ");
            Hora = Console.ReadLine();

            DataHora2 = Agenda.InicializaDataHora(Data, Hora);

            Console.Write($"\nDiferença: {Agenda.SubtraiDatas(DataHora1, DataHora2)} Dias");
            Console.WriteLine($"e {Agenda.SubtraiHoras(DataHora1, DataHora2)} Horas");

            Console.ReadKey();
        }
    }
}
