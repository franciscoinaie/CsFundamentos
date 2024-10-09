Console.WriteLine("## Estrutura De Switch || ##\n");

Console.WriteLine("Informe o mês do ano:\n");
var mes = Console.ReadLine().ToLower();

switch(mes)
{
    case "janeiro":
    case "março":
    case "abril":
    case "maio":
    case "julho":
    case "agosto":
    case "outubro":
    case "dezembro":
        Console.WriteLine("Esse mês tem 31 dias.");
        break;
    case "fevereiro":
        Console.WriteLine("Esse mês tem apenas 28 ou 29 dias.");
        break;
    default:
        Console.WriteLine("Esse mês tem 30 dias.");
        break;

}
Console.WriteLine("Fim do processamento...");
Console.ReadKey();