namespace Models04;

public class ContaPoupanca : ContaBancaria
{
    public ContaPoupanca(float saldo) : base(saldo) { }

    public override void Sacar(float valor)
    {
        if (valor > Saldo)
        {
            Console.WriteLine("Saldo Insuficiente!!");
        }
        else
        {
            Saldo -= valor;
        }
    }
}