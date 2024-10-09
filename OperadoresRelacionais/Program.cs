Console.WriteLine("### Operadores Relacionais ###\n");

int x, y;

x = 10;
y = 20;
//converttoByte esta somente para converter para 0 e 1 sendo 0 false e 1 true
//mas pode se retirar o convert e deixar somente a comparação de x == y
Console.WriteLine($"----------------\nO valor de {x} e o valor de {y} são semelhantes?");
Console.WriteLine(x == y);
Console.WriteLine("-----------------\nUsando o metodo de conversão Convert para converter em byte");
Console.WriteLine(Convert.ToByte(x == y));


//O metodo Equals é usado para comparar STRINGS

string a = "curso";
string b = "Curso";

Console.WriteLine(a.Equals(b));
Console.ReadKey();
