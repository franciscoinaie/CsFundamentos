using PartialClass;

Console.WriteLine("## USANDO O MODIFICADOR PARTIAL ##\n");

MinhaPartialClassProps  minhaPartialClassProps =  new MinhaPartialClassProps();

Console.WriteLine("Idades para nascidos em: 26/12/2003\n");

var idade = minhaPartialClassProps.CalculaIdade(new DateTime(2003, 12, 26));
Console.WriteLine($"{Math.Round(idade.TotalDays / 365)} anos");

Console.ReadKey();