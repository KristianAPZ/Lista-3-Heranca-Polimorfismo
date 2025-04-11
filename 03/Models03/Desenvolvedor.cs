namespace Models03;

public class Desenvolvedor : Funcionario
{
    public int BonusDesenvolvedor { get; set; }


    public Desenvolvedor(string nome, int salario, int bonusDesenvolvedor)
    : base(nome, salario)
    {
        this.BonusDesenvolvedor = bonusDesenvolvedor;
    }
    public override int SalarioTotal()
    {
        return Salario + BonusDesenvolvedor;
    }

    public void exibirTexto()
    {
        Console.WriteLine($"O salario total do Desenvolvedor é {SalarioTotal()}");
    }
}