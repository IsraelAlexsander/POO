using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Dados
    {        
        ArrayList ListaDeTimes = new ArrayList();        

        public void InserirTime(Times T)
        {            
            ListaDeTimes.Add(T);
        }

        public void ListarTimes()
        {
            if (ListaDeTimes.Count == 0)
                Console.WriteLine("Nenhum Time Cadastrado");
            else
                foreach (Times T in ListaDeTimes)
                {
                    T.MostrarDados();
                }
        }
    }
}
