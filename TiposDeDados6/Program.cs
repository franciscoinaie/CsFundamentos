Console.WriteLine("## Nullable Types ## \n");

//int valor = null;

Nullable<int> valor = null;
Console.WriteLine(valor);

//para facilitar, ao inves de usar a palavras nullable use ? como operado por exemplo

double? a = null;

Console.WriteLine(a);

int? b = null;

int c = b ?? 0;

Console.WriteLine("digite um numero");
int? x = Convert.ToInt32(Console.ReadLine());

if (x.HasValue)
{
    Console.WriteLine($"x = {x.Value}");
}
else
{
    Console.WriteLine($"{x}x não possui um valor contanto x = Null");
}
Console.ReadLine();