int[] numeros;

numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

string[] nomes = { "Talia", "Joana", "Angela", "Alice", "Livia", "Maria"};

//for (int i = 0; i < numeros.Length; i++) 
//{
//    Console.WriteLine($"Elemento de indice:{i} = {numeros[i]}");
//}

//for (int i = 0; i < nomes.Length; i++) 
//{
//    Console.WriteLine($"Elementos de indices, nomes:{i} = {nomes[i]}");
//}
Console.WriteLine("Exibe array original\n");
ExibeArray(nomes);

Console.WriteLine("Invertendo array\n");
Array.Reverse(nomes);
ExibeArray(nomes);

Console.WriteLine("Ordenando array\n");
Array.Sort(nomes);
ExibeArray(nomes);

Console.WriteLine("Digite por nome o array:\n");
string? nome = Console.ReadLine();


var BuscaNome = Array.BinarySearch(nomes, nome);

if (BuscaNome >= 0)
{
    Console.WriteLine($"\n{nome} foi encontrado com o indice = {BuscaNome}.\n");
}
else 
{
    Console.WriteLine($"{nome} não foi encontrado!");
}
static void ExibeArray( string[] nomes)
{
    //foreach (int numero in numeros)
  //  {
  //      Console.WriteLine(numero);

   // }
  foreach (var nome in nomes)
   {
        Console.WriteLine(nome);
   }
}