using System;
using System.Globalization;
using PooCSharp.Entity;


namespace PooCSharp;

public class Program
{
    static void Main(string[] args)
    {
        Produto p = new Produto();

        Console.Write("Informe o Nome do Produto:");
        p.Nome = Console.ReadLine();

        Console.Write("Informe o Preço do Produto:");
        p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Informe a Quantidade do Produto:");
        p.Quantidade = int.Parse(Console.ReadLine());


        Console.WriteLine("Dados do Produto: {0}, $ {1}, {2} unidades, Total:{3:F2}", p.Nome, p.Preco, p.Quantidade,
            p.ValorTotalEmEstoque());

        Console.WriteLine("Digite o numero de Produtos a ser adcionados ao estoque:");
        int qte = int.Parse(Console.ReadLine());
        p.AdcionarProdutos(qte);

        Console.WriteLine(
            "Dados Atualizados: Dados do Produto: {0}, $ {1}, {2} unidades, Total:{3:F2}", p.Nome, p.Preco,
            p.Quantidade, p.ValorTotalEmEstoque());

        Console.WriteLine("Digite o numero de Produtos a ser removidos do estoque:");
        int qty = int.Parse(Console.ReadLine());
        p.RemoverProdutos(qty);


        Console.WriteLine(
            "Dados Atualizados: Dados do Produto: {0}, $ {1}, {2} unidades, Total:{3:F2}", p.Nome, p.Preco,
            p.Quantidade, p.ValorTotalEmEstoque());
    }
}