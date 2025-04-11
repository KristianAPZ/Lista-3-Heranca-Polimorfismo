namespace Models08;

public class CD : Midia
{
    public override void ExibirDetalhes()
    {
        Console.WriteLine("Codigo: 0609-cd-2011");
        Console.WriteLine("Nome do filme: Thor");
        Console.WriteLine($"Ano do filme: 2011\n");
    }
}