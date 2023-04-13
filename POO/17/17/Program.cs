using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    internal class Program
    {
        public class OpcaoExecucao
        {
            private Operacao Opcao;

            public OpcaoExecucao(Operacao Op)
            {
                Opcao = Op;
            }

            public string ExecutarOpcao(string Texto)
            {
                string Resultado;

                Resultado = Opcao.Execute(Texto);

                return Resultado;
            }
         }

        public abstract class Operacao
        {
            public abstract string Execute(string Texto);
        }

        public class InverteTexto : Operacao
        {
            public override string Execute(string Texto)
            {
                string TextoInvertido = "";
                
                foreach (var letra in Texto)
                {
                    TextoInvertido = letra + TextoInvertido;
                }

                return TextoInvertido;
            }
        }

        public class RetiraVogais : Operacao
        {
            public override string Execute(string Texto)
            {
                string Resultado;

                Resultado = Texto.Replace("A", "");
                Resultado = Resultado.Replace("a", "");

                Resultado = Resultado.Replace("E", "");
                Resultado = Resultado.Replace("e", "");

                Resultado = Resultado.Replace("I", "");
                Resultado = Resultado.Replace("i", "");

                Resultado = Resultado.Replace("O", "");
                Resultado = Resultado.Replace("o", "");

                Resultado = Resultado.Replace("U", "");
                Resultado = Resultado.Replace("u", "");

                return Resultado;
            }
        }

        static void Main(string[] args)
        {
            string Texto = "Israel Alexsander";

            OpcaoExecucao x;

            x = new OpcaoExecucao(new InverteTexto());

            Console.WriteLine($"\nTexto Invertido = {x.ExecutarOpcao(Texto)}");

            Console.ReadKey();

            x = new OpcaoExecucao(new RetiraVogais());

            Console.WriteLine($"\nTexto sem vogais: {x.ExecutarOpcao(Texto)}");

            Console.ReadKey();
        }
    }
}
