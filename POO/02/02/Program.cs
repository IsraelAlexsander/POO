using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func[] cadastro = new Func[3];

            Func meuFunc;

            for (int i = 0; i < cadastro.Length; i++)
            {
                meuFunc = new Func();

                meuFunc.lerDados();

                cadastro[i] = meuFunc;
            }

            Console.Clear();

            foreach (Func X in cadastro)
            {
                Console.WriteLine($"{X.matricula} = {X.nome}");
                Console.WriteLine($"Salário: R$ {X.salario:f2}");
            }
        }
    }
}
