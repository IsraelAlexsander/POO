using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    internal class Vetor
    {
        public int[] V { get; set; }

        public Vetor() 
        {
            V = new int[10];

            Random x = new Random();

            for (int i = 0; i < 10; i++)
            {
                V[i] = x.Next(1, 49);
            }
        }

        public void Mostrar()
        {
            foreach (int i in V)
                Console.WriteLine($"{i,7}");

            Console.ReadKey();
        }

        public void Ordena(MyComparador MC)
        {
            int Troca = 1;

            int i = 1;

            int Aux;

            while(i <= 10 && Troca == 1)
            {
                Troca = 0;

                for(int j = 0; j <= V.Length - 2; j++)
                {
                    if (MC.Compara(V[j], V[j + 1]) == 1)
                    {
                        Troca = 1;

                        Aux = V[j];
                        V[j] = V[j + 1];
                        V[j + 1] = Aux;
                    }
                }

                i++;
            }
        }
    }    
}
