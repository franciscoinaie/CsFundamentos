internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("## Metodo e Parâmetros ##\n");

        // declarando o objeto e delcarando os valores do metodo saudacao
        MinhaClasse minhaclasse = new MinhaClasse();
        Console.WriteLine("Digite o nome:\n");
        minhaclasse.Saudacao("Maria", DateTime.Now.ToShortTimeString());
    }
}
public class MinhaClasse
{
    public void Saudacao(string nome, string data) 
    {
        Console.WriteLine(nome);
        Console.WriteLine(data);
    }
}