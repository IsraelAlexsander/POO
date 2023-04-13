using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padrao_Facede
{
    internal class MediaGeral
    {
        public bool Apta()
        {
            Console.Write("\nMédia Geral do Aluno (%): ");
            double Media = double.Parse(Console.ReadLine());

            if (Media >= 85) 
                return true;
            else
                return false;
        }
    }
}
