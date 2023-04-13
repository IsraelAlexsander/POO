using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    internal class AumentoSalarial
    {
        private EstrategiaAumento MinhaEstrategiaAumento;

        public void SetaEstrategia(EstrategiaAumento Estrategia)
        {
            this.MinhaEstrategiaAumento = Estrategia;
        }

        public double ExecuteEstrategia(double Salario)
        {
            double SalarioAtualizado;

            SalarioAtualizado = MinhaEstrategiaAumento.Execute(Salario);

            return SalarioAtualizado;
        }
    }
}
