Console.WriteLine("## Estrutura De Repetição While ##\n");

int numero;
int contador = 1;

Console.WriteLine("Digite um número maior que 0:\n");
numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0)
{
    while (contador < 11)
    {
        Console.WriteLine($"{numero} x {contador} = {numero * contador}");
        contador++;
        Console.WriteLine("/////////////////");
    }
}
else if(numero <= 0)
{
    Console.WriteLine("Apenas um número maior que 0(zero).\n");
    Console.WriteLine("Fim do processamento...");
}

Console.ReadKey();
