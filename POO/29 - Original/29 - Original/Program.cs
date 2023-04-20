using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29___Original
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList Cadastro = new ArrayList();

            DataConstrutor MinhaDataAniversario1 = new DataConstrutor();

            MinhaDataAniversario1.Dia = "09";
            MinhaDataAniversario1.Mes = "Outubro";

            AlunoConstrutor MeuAluno1 = new AlunoConstrutor(MinhaDataAniversario1);

            MeuAluno1.Nome = "Israel Alexsander";
            MeuAluno1.Mail = "ialexsander@gmail.com";
            MeuAluno1.Telefone = "9 9430-6298";

            Cadastro.Add(MeuAluno1);

            DataInterface MinhaDataAniversario2 = new DataInterface();

            MinhaDataAniversario2.Dia = "10";
            MinhaDataAniversario2.Mes = "Setembro";

            AlunoInterface MeuAluno2 = new AlunoInterface();

            MeuAluno2.Nome = "Alexsander Israel";
            MeuAluno2.Mail = "aisrael@gmail.com";
            MeuAluno2.Telefone = "8 9260 -3499";
            MeuAluno2.InjetaAniversario(MinhaDataAniversario2);

            Cadastro.Add(MeuAluno2);            

            DataPropriedade MinhaDataAniversario3 = new DataPropriedade();

            MinhaDataAniversario3.Dia = "01";
            MinhaDataAniversario3.Mes = "Janeiro";

            AlunoPropriedade MeuAluno3 = new AlunoPropriedade();

            MeuAluno3.Nome = "Rael";
            MeuAluno3.Mail = "rael@gmail.com";
            MeuAluno3.Telefone = "9 9999-9999";
            MeuAluno3.Aniversario = MinhaDataAniversario3;

            Cadastro.Add(MeuAluno3);
        }
    }
}
