using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padrao_Facede
{
    internal class Idade
    {
        public bool NaFaixa()
        {
            Console.Write("\nIdade do Aluno: ");
            int Idade = int.Parse(Console.ReadLine());

            if (Idade > 17 && Idade < 23)
                return true;
            else
                return false;
        }
    }
}
