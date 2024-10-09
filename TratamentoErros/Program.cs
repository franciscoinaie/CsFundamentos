Console.WriteLine("## Divisão de Números inteiros ##\n");
Console.WriteLine("x / y\n");

Console.WriteLine("\nDigite o valor de x:\n");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nDigite o valor de x:\n");
int y = Convert.ToInt32(Console.ReadLine());


//Bloco try catch para tratamento de erros

try
{
    //codigo que pode causar a excessao nao tratada (UNHANDLED EXCEPTION)
    int v = x / y;
    Console.WriteLine($"\n{x} / {y} = {v}");
}
catch
{
    Console.WriteLine("\nNão existe divisão por zero(0)");
}
finally 
{
    Console.WriteLine("\nProcessamento concluido...");
}



