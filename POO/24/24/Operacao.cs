using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24
{
    internal class Operacao     //Contexto      Padrão Estrategy
    {
        private EstrategiaOperacao MinhaEstrategiaOperacao;

        public void SetEstrategia(EstrategiaOperacao OP)
        {
            this.MinhaEstrategiaOperacao = OP;
        }

        public int ExecutaOperacao(int X, int Y)
        {
            int Resultado;

            Resultado = MinhaEstrategiaOperacao.ExecuteOperacao(X, Y);

            return Resultado;
        }
    }
}
