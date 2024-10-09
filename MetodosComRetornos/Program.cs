Console.WriteLine("## Metodos Com Retornos ##\n");

Calculadora calc = new();

var valor = calc.Somar(10, 10);
Console.WriteLine(valor);
Console.WriteLine(calc.Somar(10, 10));
Console.ReadKey();
public class Calculadora 
{
    //delcara o metodo como publico, depois declara que tipo de valor ele irá retornar,
    //void(vazio) ou algum valor
    public int Somar(int x, int y) 
    {
        return x + y;
    }
    public int Subtrair (int x, int y)
    {
        return x - y;
    }public int Multiplicar (int x, int y)
    {
        return x * y;
    }public int Dividir (int x, int y)
    {
        return x / y;
    }
}
