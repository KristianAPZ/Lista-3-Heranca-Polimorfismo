namespace Models01;

public abstract class Animal
{
    public string Nome { get; set; }

    public int Idade { get; set; }

    public virtual void EmitirSom()
    {
        Console.WriteLine("Som");
    }


}