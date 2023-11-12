using System;
using System.Globalization;
using ContaBancaria.Entity;

namespace ContaBancaria
{
}

public class Program
{
    static void Main(string[] args)
    {
        ContaModel conta = new ContaModel();

        Console.Write("Entre o Numero da conta:");
        conta.NumeroConta = int.Parse(Console.ReadLine());

        Console.Write("Entre o Titular da conta:");
        conta.NomeTitular = Console.ReadLine();

        Console.WriteLine("Havera depósito incial(s/n)");
        string resp = Console.ReadLine();

        Console.WriteLine("Entre o valor do Deposito inicial:");
        conta.ValorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Dados da Conta: " + conta.ToString());

        Console.WriteLine("");
        
        Console.WriteLine("Entre um valor para Deposito:");
        double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta.EntradaValorDeposito(deposito);

        Console.WriteLine("Dados da Conta Atualizado : " + conta.ToString());


        Console.WriteLine("Entre um valor para Saque:");
        double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta.RetiradaValorDeposito(saque);

        Console.Write("Dados da Conta Atualizado : " + conta.ToString());
    }
}