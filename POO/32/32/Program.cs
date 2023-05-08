using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace _32
{
    class Aluno
    {
        public string Matricula { get; set; }
        public string Nome { get; set; }
        public string eMail { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno xAluno;
            List<Aluno> ListaAlunos = new List<Aluno>();

            for(int i = 1; i <= 5; i++)
            {
                xAluno = new Aluno();

                Console.Write("\nMatricula do Aluno: ");
                xAluno.Matricula = Console.ReadLine();

                Console.Write("Nome: ");
                xAluno.Nome = Console.ReadLine();

                Console.Write("E-Mail: ");
                xAluno.eMail = Console.ReadLine();

                ListaAlunos.Add(xAluno);
                
            }

            string NomeArquivo = @"C:\Teste";    //@ serve para desconsiderar caracteres de controle
            XElement AlunoXML = new XElement("Alunos", new XAttribute("Tipo","Regular"));

            foreach(Aluno x in ListaAlunos)
            {
                AlunoXML.Add(new XElement("Aluno", new XElement("Matricula", x.Matricula), new XElement("Nome", x.Nome), new XElement("e-mail", x.eMail)));
            }
            AlunoXML.Save(NomeArquivo);

            Console.WriteLine("Documento XML criado com sucesso!\n\n");
            Console.ReadKey();

            ListaAlunos.Clear();

            AlunoXML = XElement.Load(NomeArquivo);
            
            Console.WriteLine($"Documento XML carregado com sucesso...");
            Console.ReadKey();

            xAluno = new Aluno();

            var Query = from p in AlunoXML.Elements("Aluno") select p;

            foreach(var Registro in Query)
            {
                xAluno.Matricula = Registro.Element("Matricula").Value;
                xAluno.Nome = Registro.Element("Nome").Value;
                xAluno.eMail = Registro.Element("e-mail").Value;

                ListaAlunos.Add(xAluno);
            }

            Console.WriteLine($"Dados carregados: {ListaAlunos.Count} Registros\n\n");
            Console.ReadKey();            
        }
    }
}
