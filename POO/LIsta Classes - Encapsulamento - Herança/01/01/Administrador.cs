using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class Administrador : Funcionario
    {     
        public override void LerDados()
        {
            Console.WriteLine("\nCadastro de Administrador\n");

            base.LerDados();            
        }
    }
}
