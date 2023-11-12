namespace ContaBancaria.Entity;

public class ContaModel
{
    public string NomeTitular { get; set; }
    public int NumeroConta { get; set; }

    public double ValorInicial { get; set; }

    public ContaModel()
    {
        ValorInicial = 0;
    }


    public ContaModel(string nomeTitular, int numeroConta) : this()
    {
        this.NomeTitular = nomeTitular;
        this.NumeroConta = numeroConta;
    }

    public double EntradaValorDeposito(double valor)
    {
        return ValorInicial += valor;

    }

    public double RetiradaValorDeposito(double valor)
    {
        return ValorInicial -= valor;
    }

    public override string ToString( )
    {
        return $"Conta: {NumeroConta},Titular: {NomeTitular},Saldo: {ValorInicial}";
    }
}