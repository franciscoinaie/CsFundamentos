//Console.WriteLine("\n//////////////////////////////////////////////\n");

Console.WriteLine("\nQual carro deseja pilotar:\n" +
    "1 = Chevrolet\n2 = Ford\n");
int num = Convert.ToInt32(Console.ReadLine());


if (num == 1) 
{
    Carro chevrolet = new("Sedan", "Chevrolet", "Onix", 2020, 110);
    chevrolet.Acelerar();
}
else if (num == 2)
{
    Carro ford = new("SUV", "Ford", "EcoSport", 2018, 120);
    ford.Acelerar();
}
else
{
    Console.WriteLine("Apenas 1 ou 2.");
}
Console.ReadKey();


public class Carro
{
    public Carro(String modelo, String montadora, String marca, int ano, int potencia)
    {
        Modelo = modelo;
        Montadora = montadora;
        Marca = marca;
        Ano = ano;
        Potencia = potencia;
    }
    public void Acelerando(Carro carro)
    {
        Console.WriteLine(carro.Modelo +"\n");
        Console.WriteLine(carro.Montadora +"\n");
        Console.WriteLine(carro.Marca +"\n");
        Console.WriteLine(carro.Ano +"\n");
        Console.WriteLine(carro.Potencia +"\n");
    }
   public String? Modelo;
   public String Montadora;
   public String Marca;
   public int Ano;
   public int Potencia;

    public void Acelerar() 
    {
        Acelerando(this);
        Console.WriteLine($"Acelerando o meu {Marca}");
    }
       
}