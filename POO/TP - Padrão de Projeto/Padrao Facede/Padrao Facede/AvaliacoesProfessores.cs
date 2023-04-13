using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padrao_Facede
{
    internal class AvaliacoesProfessores
    {
        public bool PeloMenosDuas()
        {
            Console.Write("\n\nPelo menos 2 avaliações positivas para participar?\nSim - Aperte 'S'\tNão - Aperte qualquer outra tecla\nOpção: ");
            char Opcao = char.Parse(Console.ReadLine().ToUpper());
            if (Opcao == 'S')
                return true;
            else
                return false;
        }
    }
}
