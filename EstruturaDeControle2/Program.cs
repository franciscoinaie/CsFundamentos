Console.WriteLine("## Estrutura de Controle If-Else ##");

Console.WriteLine("\nInsira a nota do primeiro aluno:\n");
var aluno1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nInsira a nota do segundo aluno:\n");
var aluno2 = Convert.ToInt32(Console.ReadLine());

if (aluno1 >= 6)
{
    Console.WriteLine("Aluno 1 aprovado");
}
//a instrução else if so irá ser executada após a instrução if for declarada falsa
else if (aluno1 <= 6)
{
    Console.WriteLine("Aluno 1 insuficiente para\no ensino superio");
}

if (aluno2 >= 6)
{
    Console.WriteLine("Aluno 2 aprovado");
}
else if (aluno2 <= 6)
{
    Console.WriteLine("Aluno 2 insuficiente para\no ensino superio");
}
Console.ReadKey();