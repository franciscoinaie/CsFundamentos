
public class Produto 
{
    public string? Nome { get; set; }//acessores get set
    public double Preco { get; set; }
    public double Desconto { get; set; }
    public double  PrecoFinal { get; set; }
    public int EstoqueMinimo { get; set; }

    public void Exibir() 
    {
        Console.WriteLine($"{Nome} \n Valor: {Preco.ToString("c")} \n Desconto de: {Desconto}" +
                   $"\n Valor a pagar: {PrecoFinal.ToString("c")} \n Estoque: {EstoqueMinimo}");
    }
}