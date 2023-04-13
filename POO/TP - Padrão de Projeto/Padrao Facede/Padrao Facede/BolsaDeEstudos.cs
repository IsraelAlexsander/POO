using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padrao_Facede
{
    internal class BolsaDeEstudos
    {
        public bool Tem()
        {
            Console.Write("\nO Aluno possui Bolsa de Estudos:\tSim - Aperte 'S'\tNão - Aperte qualquer outra tecla\nOpção: ");
            char Opcao = char.Parse(Console.ReadLine().ToUpper());
            if (Opcao == 'S')
                return true;
            else
                return false;
        }
    }
}
