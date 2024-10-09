using System.Security.Cryptography.X509Certificates;

Console.WriteLine("## CONSTRUTORES ESTÁTICOS ##\n");

Pessoa p1 = new();

Console.WriteLine("Digite o nome: \n");
p1.Nome = Console.ReadLine();

Console.WriteLine("\nDigite a idade:\n");
p1.Idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(p1.Idade + " - " + p1.Nome);
Console.WriteLine("Idade Minima : " + Pessoa.IdadeMinima);

Pessoa p2   = new();
Console.ReadKey();