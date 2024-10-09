Console.WriteLine("## Estrutura De Controles ##");

Console.WriteLine("\nCliente especial (S/N)");
var clienteEspecial = Console.ReadLine();

if (clienteEspecial == "s") 
        {
    Console.WriteLine("Desconto de 10% aplicado.");
}
Console.WriteLine("\n////////////////////////////");

Console.WriteLine("\nDigite o valor de x");
var x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nDigite o valor de y");
var y = Convert.ToInt32(Console.ReadLine());

if (x > y) 
    {
    Console.WriteLine($"x {x} é maior que y {y}");
}
if (x < y) 
    {
    Console.WriteLine($"x {x} é menor que y {y}");    
}
if (x == y)  
    {
    Console.WriteLine($"x {x} é igual a y {y}");
}
Console.ReadKey();