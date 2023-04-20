using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29___Original
{
    internal class DataInterface : IData
    {
		private string _Dia;

		public string Dia
		{
			get { return _Dia; }
			set { _Dia = value; }
		}

		private string _Mes;

		public string Mes
		{
			get { return _Mes; }
			set { _Mes = value; }
		}


	}
}
