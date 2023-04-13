using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal abstract class Times
    {
        public string Nome { get; set; }
        public string Presidente { get; set; }
        public string Tecnico { get; set; }
        public string DataFuncacao { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }

        public abstract void LerDados();

        public abstract void MostrarDados();
    }
}
