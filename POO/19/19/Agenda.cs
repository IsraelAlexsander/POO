using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    internal class Agenda : Calendario, Relogio
    {
        public DateTime InicializaDataHora(string XData, string XHora)
        {
            int Dia, Mes, Ano;
            int Hora, Minuto;

            Dia = Convert.ToInt16(XData.Substring(0, 2));       //DateTime aceita apenas numeros de 16bits
            Mes = Convert.ToInt16(XData.Substring(3,2));
            Ano = Convert.ToInt16(XData.Substring(6, 4));

            Hora = Convert.ToInt16(XHora.Substring(0, 2));
            Minuto = Convert.ToInt16(XHora.Substring(3, 2));

            return new DateTime(Ano, Mes, Dia, Hora, Minuto, 0);
        }
        public string SubtraiDatas(DateTime Data1, DateTime Data2)
        {
            TimeSpan Result = Data2 - Data1;

            return Result.Days.ToString();
        }

        public string SubtraiHoras(DateTime Hora1, DateTime Hora2)
        {
            TimeSpan Result = Hora2 - Hora1;

            return Result.Hours + ":" + 
                (Result.Minutes < 10 ? "0" : "") + Result.Minutes;
        }
    }
}
