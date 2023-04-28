using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31
{
    internal class ImprimeDadosComReflexao
    {
        public void Imprimir(object Obj)
        {
            Type Tipo = Obj.GetType();

            Console.Clear();

            Console.WriteLine($"Imprimindo dados para o tipo: {Tipo.Name}\n");

            foreach(var Prop in Tipo.GetProperties())
            {
                Console.WriteLine($"{Prop.Name}: {Prop.GetValue(Obj)}");
            }

            Console.ReadKey();
        }
    }
}
