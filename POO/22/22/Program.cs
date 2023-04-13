using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22
{
    internal class Program
    {
        public class Usuario
        {
            public static Usuario InstanciaUsuario = null;
            public List<string> Registros = new List<string>();
            private Usuario()
            {

            }

            public static Usuario CriaInstancia()
            {
                if (InstanciaUsuario == null)
                {
                    InstanciaUsuario = new Usuario();
                }

                return InstanciaUsuario;
            }

            

            public void MostrarRegistros()
            {
                Console.WriteLine($"Registros:\n");

                foreach(string s in Registros)
                {
                    Console.WriteLine($"{s}");
                }

                Console.ReadKey();
            }
        }
        static void Main(string[] args) //Padrão de projeto singleton
        {
            Usuario User1 = Usuario.CriaInstancia();
            User1.Registros.Add("Bob Marley");
            User1.Registros.Add("Bee Bees");

            Usuario User2 = Usuario.CriaInstancia();
            User2.Registros.Add("Jimmy Hemdrix");

            Usuario User3 = Usuario.CriaInstancia();
            User3.Registros.Add("Janis Joplin");

            User1.MostrarRegistros();            
        }
    }
}
