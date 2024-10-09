Console.WriteLine("## Operadores Unitarios & Ternário ##");

Console.WriteLine("\nInforme o valor de um número de 1 a 100:");
var n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"O valor {n} negativo é {-n}.");

Console.WriteLine("/////////////////////////////");
Console.WriteLine("\nDigite a temperatura:");
var temp = Convert.ToDouble(Console.ReadLine());

//a condição acontece em temp > 27 e usa o operador ? depois as condiçoes
var resultado = temp > 27? "Quente" : "Normal";

Console.WriteLine($"A temperatura esta {resultado}.");

Console.WriteLine("/////////////////////////////");
Console.WriteLine("\nDigite o valor de x:");
var x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o valor de y");
var y = Convert.ToInt32(Console.ReadLine());

var resultado2 = x > y ? "X é maior que Y." :
                x < y ? "X é menor que Y." :
                x == y ? "X é igual a Y." : "Sem resultado";

Console.WriteLine(resultado2);

Console.ReadKey();

