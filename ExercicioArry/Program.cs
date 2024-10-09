string[] nomes;
nomes = new string[5];
for (int i = 0; i < 5; i++)
    {
    Console.WriteLine("Digite os nomes dos alunos:\n");
      string? nome = Console.ReadLine();
    nomes[i] = nome;
    }

double[] notas;
notas = new double[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite as notas dos alunos:\n");
    double nota = Convert.ToDouble(Console.ReadLine());
    notas[i] = nota;
}


foreach (string nome in nomes)
    {
        Console.WriteLine(nome);
    }

var somaNotas = 0.0;
var totalNotas = notas.Count(); 
foreach (double nota in notas) 
{
    somaNotas += nota;
    Console.WriteLine($"{nota}");

}
Console.WriteLine($"\nMédia aritimética : \n {somaNotas/totalNotas}");

Console.ReadKey();