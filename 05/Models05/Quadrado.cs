namespace Models05;

public class Quadrado : Forma
{
    public float Lado { get; set; }

    public Quadrado(float lado) => this.Lado = lado;
    public override float CalcularArea()
    {
        return Lado * Lado;
    }

    public void ExibirArea()
    {
        Console.WriteLine($"A area do Quadrado é {CalcularArea()}");
    }
}