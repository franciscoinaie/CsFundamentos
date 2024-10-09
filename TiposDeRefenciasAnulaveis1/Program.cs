Console.WriteLine("## Tipos De Referencias Anuláveis ##\n");

string? nomes = null;

nomes = Console.ReadLine();
//? é o condicional dos tipos nulos

Console.WriteLine(nomes?.ToUpper());
Console.ReadKey();