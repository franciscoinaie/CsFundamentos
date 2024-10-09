Console.WriteLine("## Instrução While || ##\n");

while (true) 
{
    Console.WriteLine("Digite um número maior que 0 e menor que 100:\n");
    int numero = Convert.ToInt32(Console.ReadLine());

    if (numero == 100) 
    {
        break;
    }
    else if (numero == 0) 
    {
        break;
    }
    if (numero%2 == 0) 
    {
        Console.WriteLine($"O número {numero} é par");
    } 
    else
    {
        Console.WriteLine($"O número {numero} é  ímpar");
    }
    Console.WriteLine("Fim do processamento...");
}
Console.ReadKey();
