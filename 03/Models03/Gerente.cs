namespace Models03;

public class Gerente : Funcionario
{
    public int BonusGerente { get; set; }

    public Gerente(string nome, int salario, int bonusGerente)
    : base(nome, salario)
    {
        this.BonusGerente = bonusGerente;
    }

    public override int SalarioTotal()
    {
        return Salario + BonusGerente;
    }

    public void exibirTexto()
    {
        Console.WriteLine($"O salario total do Gerente é {SalarioTotal()}");
    }
}