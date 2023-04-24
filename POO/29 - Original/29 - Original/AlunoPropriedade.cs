using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29___Original
{
    internal class AlunoPropriedade
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

		public IData Aniversario
		{
			get { return _Aniversario; }
			set { _Aniversario = value; }
		}

	}
}
