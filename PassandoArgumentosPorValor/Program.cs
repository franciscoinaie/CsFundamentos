Console.WriteLine("## PASSANDO ARGUMENTOS POR VALOR ##\n");

int x = 20;

Console.WriteLine("Valor do argumento x antes de passar por valor: " + x);

Calculo calc = new();
calc.Dobrar(x);

Console.WriteLine("Valor do argumento x depois de passar pelo metodo dobrar: "+ x);

Console.ReadKey();

public class Calculo
{
    public void Dobrar (int y)
    {
        y *= 2; //y=y*2
        Console.WriteLine("Valor do parâmetro y no metodo dobrar: " + y);
    }
}