using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList Cadastro = new ArrayList();

            Fisica pFis;
            Juridica pJur;

            pFis = new Fisica();
            pFis.lerDados();

            Cadastro.Add(pFis);

            pFis = new Fisica();
            pFis.lerDados();

            Cadastro.Add(pFis);

            //----------------------------------//

            pJur = new Juridica();
            pJur.lerDados();

            Cadastro.Add(pJur);

            pJur = new Juridica();
            pJur.lerDados();

            Cadastro.Add(pJur);

            Console.Clear();

            foreach(object x in Cadastro)
            {
                if (x.GetType() == typeof(Fisica))
                {
                    Fisica PF = (Fisica)x;

                    Console.WriteLine($"{PF.nome}\nCPF: {PF.cpf}\nSexo: {PF.sexo}\n");
                }
                else
                {
                    Juridica PJ = (Juridica)x;
                    Console.WriteLine($"{PJ.nome}\nCNPJ: {PJ.cnpj}\n");
                }
            }

            Console.ReadKey();
        }
    }
}
