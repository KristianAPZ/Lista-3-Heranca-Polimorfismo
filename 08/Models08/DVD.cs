namespace Models08;

public class DVD : Midia
{
    public override void ExibirDetalhes()
    {
        Console.WriteLine("Código: 0308-DVD-2015");
        Console.WriteLine("Nome do filme: Avengers Age of Ultron");
        Console.WriteLine("Ano do filme: 2015");
    }
}