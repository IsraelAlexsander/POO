using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class Carga : Veiculo
    {
        public double CapacidadeCarga { get; set; }

        public override void MostrarDados()
        {
            Console.WriteLine($"\n{Marca} {Modelo} {AnoFabricacao} - Placa: {Placa}");
            Console.WriteLine($"Capacidade de Carga: {CapacidadeCarga}");
        }

        public override double CalcularValor()
        {
            return base.CalcularValor() * 1.10;
        }
    }
}
