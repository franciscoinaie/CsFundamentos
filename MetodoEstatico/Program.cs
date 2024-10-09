Console.WriteLine("## METODOS ESTATICOS #\n");


Calculadora calc = new();

var somar = Calculadora.Somar(10, 10);
var subtrair = Calculadora.Subtrair(10, 10);
var multiplicar = Calculadora.Multiplicar(10, 10);
var dividir = Calculadora.Dividir(10, 10);
var resto = Calculadora.Resto(10, 10);

Console.WriteLine(somar);
Console.WriteLine(subtrair);
Console.WriteLine(multiplicar);
Console.WriteLine(dividir);
Console.WriteLine(resto);

Console.ReadKey();


public class Calculadora 
{
    //Aplicando o modificador static, deixando os metodos estáticos
    //Dessa forma, o metodo passa a ser da classe e não precisa de um objeto
    //podendo ser chamado pela propria classe ao inves de ser instanciado
    public static int Somar(int num1, int num2)
    {
        return num1 + num2;
    } public static int Subtrair(int num1, int num2)
    {
        return num1 - num2;
    } public static int Multiplicar(int num1, int num2)
    {
        return num1 * num2;
    } public static int Dividir(int num1, int num2)
    {
        return num1 / num2;
    } public static int Resto(int num1, int num2)
    {
        return num1 % num2;
    }
}