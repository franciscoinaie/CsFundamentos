Console.WriteLine("## ENUMERAÇÃO\n ##");

Console.WriteLine($"{^(int)DiasDaSemana.Terça},\n {(int)DiasDaSemana.Domingo}");
Console.ReadKey();


enum Categorias 
{
    Moda,
    Automotivo,
    Artes,
    Bebidas,
    Livros,
    Brinquedos  
}
enum DiasDaSemana 
{
    Segunda = 0,
    Terça = 1,
    Quarta,      //2
    Quinta,      //3
    Sexta,       //4
    Sábado,      //5
    Domingo,     //6
}