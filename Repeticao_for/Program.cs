Console.WriteLine("### Instrução For ###\n");

int numero, resultado;

Console.WriteLine("Digite um numero até 10: \t");
numero = Convert.ToInt32(Console.ReadLine());

//int i é  o inicializa o loop, depois vem a condição e logo após vem o incremento
for (int i = 0; i <= 10; i++) 
{
    resultado = numero * i;
    Console.WriteLine($"Tabuada do {numero} x {i} = {resultado}");
}

Console.WriteLine("Fim do processamento...");
Console.ReadKey();
