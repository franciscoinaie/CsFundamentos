using System.Security.AccessControl;

Console.WriteLine("### Entrada de Dados ###");

Console.WriteLine("\nQual o seu nome?");

String nome = Console.ReadLine();

Console.WriteLine($"Bem-vindo, seu nome é {nome}!\n");

Console.WriteLine("Bem-vindo, seu nome é "+ nome+"!");

Console.WriteLine("\nQual sua idade?");

int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sua idade é " + idade + " anos");

Console.WriteLine($"Sua idade é {idade} anos");

Console.ReadKey();
