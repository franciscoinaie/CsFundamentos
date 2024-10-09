internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("## THIS ##\n");
        
        Teste t1 = new();
        t1.num1 = 10;
        t1.num2 = 20;
        t1.Exibir();
        Teste t2 = new();
        t2.num1 = 99;
        t2.num2 = 100;
        t2.Exibir();
        Console.ReadKey();
    }

}

public class Teste
{
    public int num1;
    public int num2;

    public void PassarParametros(Teste t) 
    {
        Console.WriteLine($"\nThis = {this}");
        Console.WriteLine("Num1:" + t.num1);
        Console.WriteLine("Num1:" + t.num2);
    }
    public void Exibir()
    {
        PassarParametros(this);
    }
}
