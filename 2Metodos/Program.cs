internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("## Metodos ##\n");

        MinhaClasse minhaClasse = new MinhaClasse();

        minhaClasse.Saudacao();


        Console.ReadKey();
    }
}

//criando uma classe
class MinhaClasse 
{
    //criando metodo
    public void Saudacao() 
    {
        Console.WriteLine("Bem-vindo!");
    }
    public void DataAtual() 
    {
        Console.WriteLine(DateTime.Now.ToShortDateString());
    }

}
