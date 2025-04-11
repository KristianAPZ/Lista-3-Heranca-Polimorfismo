namespace Models05;

public class Triangulo : Forma
{
    public float Altura { get; set; }
    public float BaseT { get; set; }

    public Triangulo(float altura, float baseT)
    {
        this.Altura = altura;
        this.BaseT = baseT;
    }
    public override float CalcularArea()
    {
        return BaseT * Altura / 2;
    }

    public void ExibirArea()
    {
        Console.WriteLine($"A area do Triangulo é {CalcularArea()}");
    }
}