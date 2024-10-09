Console.WriteLine("## Estrutura de Repetição Goto/Label ##");

Console.WriteLine("Digite um valor abaixo de 10");
var i =Convert.ToInt32(Console.ReadLine());

repetir:
Console.WriteLine($"Valor de i {i}");

i++;
if (i <= 10)
    goto repetir;

    Console.WriteLine("Fim do processamento...");


Console.ReadKey();

