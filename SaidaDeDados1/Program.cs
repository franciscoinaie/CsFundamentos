Console.WriteLine("SAIDA DE DADOS : FORMATAÇÃO\n");

int idade = 25;
string nome = "Maria";

Console.Write(nome);
Console.Write(idade);
Console.WriteLine("\n------------------------");

Console.Write(nome);
Console.Write(" tem ");
Console.Write(idade);
Console.Write(" anos \n");

Console.Write("----Concatenação----\n");
//para usar a concatenação, utiliza o operador + por exemplo:
Console.WriteLine(nome + " tem " + idade + " anos. \n");

Console.WriteLine("----Interpolação----");
//para usar a interpolação, utiliza o operador $ por exemplo:
Console.WriteLine($"{nome} tem {idade} anos.\n");

Console.WriteLine("----Place Holders----\n");
//para utilizar os Place Holders, se usa os operadores numericos em ordem crescente, por exemplo:
Console.WriteLine("{0} tem {1} anos.\n", nome, idade);

Console.ReadLine();