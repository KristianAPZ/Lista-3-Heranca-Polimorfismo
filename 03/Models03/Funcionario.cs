namespace Models03;

public abstract class Funcionario
{
    public string Nome { get; set; }
    public int Salario { get; set; }

    public Funcionario(string nome, int salario)
    {
        this.Nome = nome;
        this.Salario = salario;
    }

    public virtual int SalarioTotal()
    {
        return Salario;
    }


}