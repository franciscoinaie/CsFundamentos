Console.WriteLine("## PASSANDO PARAMETROS OPCIONAIS ##");

Console.WriteLine("Qual o destino:\n ");
var destino = Console.ReadLine();

Console.WriteLine("Informe o titulo :\n ");
var titulo = Console.ReadLine();

Console.WriteLine("Qual o assunto:\n ");
var assunto = Console.ReadLine();

Email email = new();
email.Enviar();//usando parametros padrao sem passar parametros devidamente

email.Enviar(destino, titulo, assunto);

Console.ReadKey();


public class Email 
{
    public void Enviar(string destino = "Destino padrão", string titulo = "Título padrão", string assunto = "Assunto padrão") 
    {
        Console.WriteLine($"\nPara {destino} - {titulo} \n {assunto}");
    }
}