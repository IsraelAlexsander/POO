using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal abstract class Veiculo
    {
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int AnoFabricacao { get; set; }
        public double ValorKmRodado { get; set; }        
        public double KmInicial { get; set; }
        public double KmFinal { get; set; }
        public double ValorLocacao { get; set; }

        public abstract void MostrarDados();
        public virtual double CalcularValor()
        {
            double KmRodados = KmFinal - KmInicial;
            ValorLocacao = KmRodados * ValorKmRodado;
            return this.ValorLocacao;
        }
    }
}
