using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padrao_Facede
{
    internal class Regular
    {
        public bool ERegular()
        {
            Console.Write("\nO Aluno é Regular:\tSim - Aperte 'S'\tNão - Aperte qualquer outra tecla\nOpção: ");
            char Opcao = char.Parse(Console.ReadLine().ToUpper());
            if (Opcao == 'S')
                return true;
            else
                return false;
        }
    }
}
