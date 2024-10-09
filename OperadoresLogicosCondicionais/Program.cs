Console.WriteLine("### Operadores Logicos ###\n----------------------");

bool c1 = 5 >= 7;
bool c2 = 9 != 8;
bool resultado;

Console.WriteLine($"O resultado de c1 {c1}");
Console.WriteLine($"O resultado de c2 {c2}\n-----------------------");

//Operador AND --> &&
resultado = c1 && c2;
Console.WriteLine("Operador AND(&&):\n" + resultado);

bool resultado2  = c1 || c2;

Console.WriteLine("Operador Or(||)\n"+ resultado2);


Console.ReadKey();