Console.WriteLine("## STRUCTS ##\n");

Console.ReadLine();
Pessoa pessoa = new();



Console.ReadKey();

public struct Pessoa 
{
    public string? Nome { get; set; }
    public int Idade { get; set; }
    public Pessoa(string? nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
    public void Exibir() 
    {
        Console.WriteLine("\nStruct");
    }
}