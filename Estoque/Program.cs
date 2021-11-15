using System;
using System.Globalization;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            //realizando a entrada dos produtos
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());


            //imprimindo saida dos dados
            Console.WriteLine();
            Console.WriteLine($"Dados do produto: {p}");

            //entrada do valor a ser adicionado
            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos a serem adicionado: ");
            int qtde = int.Parse(Console.ReadLine());

            //calculando a adição dos produtos
            p.AdicionarProdutos(qtde);
            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {p}");

            //entrada do valor a ser removida
            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos a serem removidos: ");
            qtde = int.Parse(Console.ReadLine());

            //calculando a remoçãp dos produtos
            Console.WriteLine();
            p.RemoverProdutos(qtde);
            Console.Write($"Dados atualizados: {p}");
        }
    }
}
