ClasseDerivada cd = new();

cd.AcessoClasse();


Console.ReadKey(); 

public class ClasseDerivada : ClasseBase 
{ 
    public void AcessoClasse() 
    {
      Public_Membro();
      Internal_Membro();
      Protected_Membro();
      Protected_Internal_Membro();
    }
}

public class ClasseBase 
{
    public void Public_Membro() 
    {
        Console.WriteLine("Classe Base - Membro Public");
    }
    private void Private_Membro() 
    {
        Console.WriteLine("Classe Base - Membro Private");
    }
    internal void Internal_Membro() 
    {
        Console.WriteLine("Classe Base - Membro Internal");
    }
    protected void Protected_Membro() 
    {
        Console.WriteLine("Classe Base - Membro Protected");
    }
    protected internal void Protected_Internal_Membro() 
    {
        Console.WriteLine("Classe Base - Membro Protected Internal");
    }
}