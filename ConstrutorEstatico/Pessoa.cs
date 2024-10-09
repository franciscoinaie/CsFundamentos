public class Pessoa
{

    public static int IdadeMinima;

    public int Idade { get; set; }
    public string Nome { get; set; } = string.Empty;

    public Pessoa(int idade, string nome)
    {
        Console.WriteLine("Executando o contrutor parametrizado\n");
        int Idade = idade;
        string Nome = nome;
    }
    public Pessoa()
    {
        
    }
     static Pessoa()
    {
        Console.WriteLine("Executando o contrutor estático\n");
        Console.WriteLine("inicializando o campo IdadeMinima\n");
        IdadeMinima = 18;
    }
}