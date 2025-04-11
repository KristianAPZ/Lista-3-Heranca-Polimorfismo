namespace Models04;

public abstract class ContaBancaria
{
    public float Saldo { get; protected set; }

    public ContaBancaria(float saldoInicial)
    {
        Saldo = saldoInicial;
    }

    public void Depositar(float valor)
    {
        Saldo += valor;
    }

    public abstract void Sacar(float valor);

    public void ExibirSaldo()
    {
        Console.WriteLine($"O saldo é de {Saldo} reais");
    }

}