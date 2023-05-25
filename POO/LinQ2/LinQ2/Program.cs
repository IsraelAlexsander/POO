using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ2
{
    class Produtos
    {
        public string CodProduto { get; set; }
        public string NomeProduto { get; set; }
        public string Categoria { get; set; }
        public double PrecoUnit { get; set; }
    }

    class Categorias
    {
        public string CodCategoria { get; set; }
        public string DescCategoria { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Categorias> ListaCategorias = new List<Categorias>();

            Categorias xCategoria;

            xCategoria = new Categorias();
            xCategoria.CodCategoria = "123";
            xCategoria.DescCategoria = "Limpeza";
            ListaCategorias.Add(xCategoria);

            xCategoria = new Categorias();
            xCategoria.CodCategoria = "456";
            xCategoria.DescCategoria = "Padaria";
            ListaCategorias.Add(xCategoria);

            xCategoria = new Categorias();
            xCategoria.CodCategoria = "789";
            xCategoria.DescCategoria = "Bebidas";
            ListaCategorias.Add(xCategoria);

            List<Produtos> ListaProdutos = new List<Produtos>();

            Produtos xProdutos;

            xProdutos = new Produtos();
            xProdutos.CodProduto = "P1";
            xProdutos.NomeProduto = "Ciabata Recheada";
            xProdutos.Categoria = "456";
            xProdutos.PrecoUnit = 15.80;
            ListaProdutos.Add(xProdutos);

            xProdutos = new Produtos();
            xProdutos.CodProduto = "P2";
            xProdutos.NomeProduto = "Sabão em Pò OMO";
            xProdutos.Categoria = "123";
            xProdutos.PrecoUnit = 24.90;
            ListaProdutos.Add(xProdutos);

            xProdutos = new Produtos();
            xProdutos.CodProduto = "P3";
            xProdutos.NomeProduto = "Pão de Queijo";
            xProdutos.Categoria = "456";
            xProdutos.PrecoUnit = 3.80;
            ListaProdutos.Add(xProdutos);

            xProdutos = new Produtos();
            xProdutos.CodProduto = "P4";
            xProdutos.NomeProduto = "Vodka Absolut";
            xProdutos.Categoria = "789";
            xProdutos.PrecoUnit = 92.30;
            ListaProdutos.Add(xProdutos);

            xProdutos = new Produtos();
            xProdutos.CodProduto = "P5";
            xProdutos.NomeProduto = "Veja Multiuso";
            xProdutos.Categoria = "123";
            xProdutos.PrecoUnit = 4.70;
            ListaProdutos.Add(xProdutos);

            xProdutos = new Produtos();
            xProdutos.CodProduto = "P6";
            xProdutos.NomeProduto = "Cachaça Salinas";
            xProdutos.Categoria = "789";
            xProdutos.PrecoUnit = 42.30;
            ListaProdutos.Add(xProdutos);

            xProdutos = new Produtos();
            xProdutos.CodProduto = "P7";
            xProdutos.NomeProduto = "Wiskey Chivas Reagal";
            xProdutos.Categoria = "789";
            xProdutos.PrecoUnit = 145.90;
            ListaProdutos.Add(xProdutos);

            var ProdCateg = from Cat in ListaCategorias
                            join Prod in ListaProdutos on Cat.CodCategoria equals Prod.Categoria
                            orderby Prod.NomeProduto
                            select new
                            {
                                NomeProduto = Prod.NomeProduto,
                                NomeCategoria = Cat.DescCategoria,
                                PrecoUnitario = Prod.PrecoUnit
                            };

            foreach(var x in ProdCateg)
            {
                Console.WriteLine($"{x.NomeProduto} - ({x.NomeCategoria}) - R$ {x.PrecoUnitario,8}");
            }

            Console.ReadKey();

            Console.Clear();

            var GrupoProdutos = from P in ProdCateg
                                group P by P.NomeCategoria into G   // G é um nome para o novo agrupamento
                                select new { Cat = G.Key, Prod = G };

            foreach (var Grupo in GrupoProdutos)
            {
                Console.WriteLine($"Categoria: {Grupo.Cat}");
                
                foreach(var GrupoProd in Grupo.Prod)
                {
                    Console.WriteLine($"\t==> {GrupoProd.NomeProduto} - R$ {GrupoProd.PrecoUnitario}");
                }
            }
            Console.ReadKey();
        }
    }
}
