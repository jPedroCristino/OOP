using System;
using System.Globalization;
using System.Xml;
using ProdutoMercado;

namespace Mercado
{
    class Program
    {
        static void Main(string[] args) {

            Produto p = new Produto();

            Console.WriteLine("Entre os dados do Produto");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do produto: " + p);

        }
    }
}
