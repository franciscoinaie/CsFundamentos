internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("## METODOS E PARAMETROS ##\n");

        Aluno aluno = new Aluno();

        Console.WriteLine("Nome : ");
        aluno.Nome = Console.ReadLine();

        Console.WriteLine("Idade : ");
        aluno.Idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Sexo : ");
        aluno.Sexo = Console.ReadLine();

        Console.WriteLine("Aprovado : (S)im (N)ão\n");
        aluno.Aprovado = Console.ReadLine();

        //forma mais simples de instancia um objeto
        Curso curso = new();
        //(aluno.Nome, aluno.Idade, aluno.Sexo, aluno.Aprovado)ANTIGOS PARÂMETROS
        curso.Resultado(aluno);

        Console.ReadKey();
    }
}

public class Aluno 
{
    public string? Nome;
   public int Idade;
   public string? Sexo;
    public string? Aprovado;
}
public class Curso 
{
    //(string nome, int idade, string sexo, string aprovado) ANTIGOS PARÂMETROS
    //forma mais curta de se fazer os parâmetros
    public void Resultado(Aluno aluno) 
    {
        Console.WriteLine($"O(a) aluno(a) {aluno.Nome} ({aluno.Sexo}), com {aluno.Idade} anos");
        if (aluno.Aprovado == "S") 
        {
            Console.WriteLine("Aluno(a) Aprovado(a)");
        }
        else
        {
            Console.WriteLine("Aluno(a) Reprovado(a)");
        }
    }
}