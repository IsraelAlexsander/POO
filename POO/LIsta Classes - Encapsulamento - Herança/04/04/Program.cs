using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ArrayList Veiculos = new ArrayList();

            #region Cadastro Veiculos
            Passeio P;

            P = new Passeio();

            P.Placa = "AAAAA";

            P.Marca = "Fiat";

            P.Modelo = "Palio";

            P.AnoFabricacao = 2020;

            P.ValorKmRodado = 10;

            P.ArCondicionado = "Não Possui";

            P.TipoCombustivel = "Gasolina";

            P.NumeroPortas = 4;      

            Veiculos.Add(P);

            P = new Passeio();

            P.Placa = "BBBBB";

            P.Marca = "Volkswagen";

            P.Modelo = "Gol";

            P.AnoFabricacao = 2021;

            P.ValorKmRodado = 13;

            P.ArCondicionado = "Possui";

            P.TipoCombustivel = "Gasolina";

            P.NumeroPortas = 4;

            Veiculos.Add(P);

            P = new Passeio();

            P.Placa = "CCCCC";

            P.Marca = "Ford";

            P.Modelo = "KA";

            P.AnoFabricacao = 2023;

            P.ValorKmRodado = 15;

            P.ArCondicionado = "Possui";

            P.TipoCombustivel = "Gasolina/Alcool";

            P.NumeroPortas = 4;

            Veiculos.Add(P);

            Carga C;

            C = new Carga();

            C.Placa = "DDDDD";

            C.Marca = "Mercedes-Benz";

            C.Modelo = "Sprinter";

            C.AnoFabricacao = 2023;

            C.ValorKmRodado = 25;

            C.CapacidadeCarga = 1360;

            Veiculos.Add(C);

            C = new Carga();

            C.Placa = "EEEEE";

            C.Marca = "Hyundai";

            C.Modelo = "HD 78";

            C.AnoFabricacao = 2020;

            C.ValorKmRodado = 30;

            C.CapacidadeCarga = 4300;

            Veiculos.Add(C);
            #endregion

            int Opcao;
            do
            {
                Menu:
                Console.Clear();                
                Console.WriteLine("1 - Listar Veículos");
                Console.WriteLine("2 - Consultar Valor de Locação");
                Console.WriteLine("3 - Sair");
                Console.Write("Opção: ");
                Opcao = int.Parse(Console.ReadLine());

                switch (Opcao)
                {
                    case 1: // Listar Veículos
                        Console.Clear();

                        ListarVeiculos(Veiculos);

                        Console.ReadKey();

                        break;
                    case 2: //Consultar Valor de Locação
                        Console.Clear();

                        Console.Write("Digite a Placa do Veículo que deseja consultar: ");
                        string PlacaConsulta = Console.ReadLine().ToUpper();

                        Veiculo V = EncontrarVeiculo(Veiculos, PlacaConsulta);

                        if (V == null)
                        {
                            Console.WriteLine("Não possuimos um Veículo com essa placa");
                        }
                        else
                        {
                            V.MostrarDados();

                            Console.Write("\nKm Inicial: ");
                            V.KmInicial = double.Parse(Console.ReadLine());
                            Console.Write("Km Final: ");
                            V.KmFinal = double.Parse(Console.ReadLine());
                            
                            Console.WriteLine($"O Valor da Locação do Veículo é: R$ {V.CalcularValor()}\n");
                        }

                        Console.ReadKey();

                        break;
                }
            } while (Opcao != 3);
        }

        static void ListarVeiculos(ArrayList Veiculos)
        {
            foreach(Veiculo P in Veiculos)
            {
                if (P.GetType() == typeof(Passeio))
                {
                    Console.WriteLine("Veículo de Passeio");
                    P.MostrarDados();
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.WriteLine("Veículo de Carga");
                    P.MostrarDados();
                    Console.WriteLine("\n");
                }
            }
        }

        static Veiculo EncontrarVeiculo(ArrayList Veiculos, string Placa)
        {
            Veiculo Veiculo = null;

            foreach(Veiculo V in Veiculos)
                if (Placa == V.Placa)
                    Veiculo = V;

            return Veiculo;
        }        
    }
}
