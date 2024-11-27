Console.WriteLine("## HERANÇA ##!\n");

Funcionario funci = new();

funci.Nome = "José Dos Santos";
funci.Email = "josedossantos@gmail.com";
funci.Empresa = "Microsoft";
funci.Salario = 35000;

funci.Identificar();
Console.WriteLine(funci.Nome);
Console.WriteLine(funci.Empresa);
Console.WriteLine(funci.Salario);

Console.WriteLine("\n//////////////////////////////\n");

Alunos aluno = new();

aluno.Nome = "Maria Da Silva";
aluno.Email = "mariasilva@gmail.com";
aluno.Curso = "Ánalise e Desenvolvimento de Sistemas";
aluno.Nota = 9.9;

aluno.Identificar();
Console.WriteLine(aluno.Nome);
Console.WriteLine(aluno.Curso);
Console.WriteLine(aluno.Nota);


Console.ReadLine();


public class Pessoa
{
    public string? Nome { get; set; }
    public string? Email { get; set; }

    public void Identificar() 
    {
        Console.WriteLine($"{Nome} - {Email}");
    }
}

public class Funcionario : Pessoa 
{
    public string? Empresa { get; set; }
    public int Salario { get; set; }
    
}

public class Alunos : Pessoa 
{
    public string? Curso { get; set; } 
    public double? Nota { get; set; }
}