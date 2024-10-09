Console.WriteLine("### Operações Aritmeticos ###\n");

Console.WriteLine("Informe o valor de x:\n");
int x = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Informe o valor de y:\n");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A raiz quadrada de x é ={Math.Sqrt(x)}");
Console.WriteLine($"Potencia de x elevado a y ={Math.Pow(x, y)}");
Console.WriteLine($"Valor minimo entre x e y ={Math.Min(x, y)}");
Console.WriteLine($"Valor maximo entre x e y ={Math.Max(x, y)}");
Console.WriteLine($"Coseno de x ={Math.Cos(x)}");
Console.WriteLine($"Seno de x ={Math.Sin(x)}");
Console.WriteLine($"Exponencial de x ={Math.Exp(x)}");


Console.ReadKey();

//Console.WriteLine($"Somados, o valor de x+y é = {x + y}");
//Console.WriteLine($"Subtradídos, o valor de x-y é = {x - y}");
//Console.WriteLine($"multiplicados, o valor de x*y é = {x * y}");
//Console.WriteLine($"divididos, o valor de x/y é = {x / y}");
//Console.WriteLine($"Modulos, o valor de x%y é = {x % y}");

