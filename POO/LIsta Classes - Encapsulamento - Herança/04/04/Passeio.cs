using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class Passeio : Veiculo
    {
        public string ArCondicionado { get; set; }
        public string TipoCombustivel { get; set; }
        public int NumeroPortas { get; set; }

        public override void MostrarDados()
        {
            Console.WriteLine($"\n{Marca} {Modelo} {AnoFabricacao} - Placa: {Placa}");
            Console.WriteLine($"Ar Condicionado: {ArCondicionado}");
        }
    }
}
