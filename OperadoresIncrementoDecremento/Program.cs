Console.WriteLine("## Operadores Incremeneto e Descremento ##\n");


var x = 0;
//x++;
//x--;
//++x;
//--x;
Console.WriteLine($"Pre incremento ===>{x}\n");
int resultado = ++x + 10;
Console.WriteLine(x);
Console.WriteLine(resultado);


Console.WriteLine($"\nPos Incremento ===>{x}\n");
resultado = x++ + 10;
Console.WriteLine(x);
Console.WriteLine(resultado);



Console.ReadKey();