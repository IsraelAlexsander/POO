using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    internal class PrimoAcima : IPrimo
    {
        public int AchaPrimo(int N)
        {
            int ContaDiv;

            for (int i = N+1; ; i++) 
            {
                ContaDiv = 0;
                for (int j = 1; j <= i; j++)                
                    if (i % j == 0)
                        ContaDiv++;                

                if (ContaDiv == 2)                
                    return i;                
            }
        }
    }
}
