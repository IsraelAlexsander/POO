using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMinha
{
    public class Operacoes
    {
        public static int[] CriarVetor(int Tam, bool Randomiza)
        {
            int [] Result = new int[Tam];

            if (Randomiza)
            {
                Random x = new Random();
                for (int i = 0; i < Result.Length; i++)                
                    Result[i] = x.Next(0, 51);                
            }

            return Result;
        }
        
        public static int Somar(int[] Vetor)
        {
            int Soma = 0;

            for (int i = 0; i < Vetor.Length; i++)            
                Soma += Vetor[i];

            return Soma;
        }

        public static int AcharMaior(int[] Vetor)
        {
            int Maior = Vetor[0];

            for (int i = 1; i < Vetor.Length; i++)            
                if (Vetor[i] > Maior)
                    Maior = Vetor[i];            

            return Maior;
        }

        public static int AcharMenor(int[] Vetor)
        {
            int Menor = Vetor[0];

            for (int i = 1; i < Vetor.Length; i++)
                if (Vetor[i] < Menor)
                    Menor = Vetor[i];

            return Menor;
        }
    }
}
