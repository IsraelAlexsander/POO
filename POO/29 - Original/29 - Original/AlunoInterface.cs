using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29___Original
{
    internal class AlunoInterface : IDataInterface
    {
        private string _Nome;

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        private string _Mail;

        public string Mail
        {
            get { return _Mail; }
            set { _Mail = value; }
        }

        private string _Telefone;

        public string Telefone
        {
            get { return _Telefone; }
            set { _Telefone = value; }
        }

        private IData _Aniversario;
        
        public void InjetaAniversario(IData Data)
        {
            _Aniversario = Data;
        }
    }
}
