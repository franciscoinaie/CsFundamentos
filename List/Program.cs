List<string> frutas = new() 
{ 
    "Uva", "Pera", "Banana", "Maçã", "Abacate", "Laranja", "Mamão"
};

var frutas1 = frutas.Find(Procura);
Console.WriteLine(frutas1);

Console.ReadKey();

static bool Procura(string item)
{
    return item.StartsWith("");
} 