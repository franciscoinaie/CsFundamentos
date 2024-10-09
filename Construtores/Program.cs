internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("## CONSTRUTORES ##\n");

        Aluno aluno = new("Talia", 20, "Feminino", "S");

        Console.WriteLine(aluno.Nome == null ? "null" : aluno.Nome);
        Console.WriteLine(aluno.Idade);
        Console.WriteLine(aluno.Sexo == null ? "null" : aluno.Sexo);
        Console.WriteLine(aluno.Aprovado == null ? "null" : aluno.Aprovado);

        Console.ReadKey();
    }
}

public class Aluno
{
    //digite ctor para criar um construtor sem parametros
    public Aluno(string nome)
    {
        
    }
    //construtor padrao fica oculto dentro da class
    public Aluno(string nome, int idade, string sexo, string aprovado) 
    {
        Nome = nome;
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }

    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
}