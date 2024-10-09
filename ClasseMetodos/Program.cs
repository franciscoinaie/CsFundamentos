Console.WriteLine("## Classe e Metodo ##\n");


//Objetos Pessoa p1 e p2 são armazenados na memoria Heap e são tipos por referências
Pessoa p1;
p1 = new Pessoa();
Console.WriteLine("Diga o nome da pessoa:\n");
p1.Nome = Convert.ToString(Console.ReadLine());

Console.WriteLine("\nQual a idade da pessoa:\n");
p1.Idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nInforme o sexo:\n");
p1.Sexo = Convert.ToString(Console.ReadLine());

Console.WriteLine(" "+p1.Nome + "\n " +p1.Idade+ " anos" + "\n "+p1.Sexo);

Console.ReadKey();

class Pessoa
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Emprego;
}