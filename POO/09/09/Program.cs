using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList Cadastro = new ArrayList();

            Engenheiro Eng;
            Medico Med;

            Med = new Medico();
            Med.lerDados();
            Cadastro.Add(Med);

            Med = new Medico();
            Med.lerDados();
            Cadastro.Add(Med);

            Eng = new Engenheiro();
            Eng.lerDados();
            Cadastro.Add(Eng);

            Eng = new Engenheiro();
            Eng.lerDados();
            Cadastro.Add(Eng);

            foreach(object p in Cadastro)
            {
                if (p.GetType() == typeof(Medico))
                {
                    Medico M = (Medico)p;

                    M.mostrarDados();
                }

                else
                {
                    Engenheiro E = (Engenheiro)p;

                    E.mostrarDados();
                }

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
