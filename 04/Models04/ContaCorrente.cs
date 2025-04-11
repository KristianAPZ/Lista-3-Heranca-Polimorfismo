namespace Models04;

public class ContaCorrente : ContaBancaria
{
    public ContaCorrente(float saldo) : base(saldo) { }

    public override void Sacar(float valor)
    {
        Saldo -= valor;
    }

    public new void ExibirSaldo()
    {
        Console.WriteLine($"O saldo final é de {Saldo}");
    }
}