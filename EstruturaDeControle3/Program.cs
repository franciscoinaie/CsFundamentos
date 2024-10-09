Console.WriteLine("## Estrutura Switch-Case ##\n");

//int compra = 600;

//Console.WriteLine("Valor da compra 600,00R$.\n");

//Console.WriteLine("Informe o número de parcelas: 1 a 3.\n");
//var parcelas = Convert.ToInt32(Console.ReadLine());

//switch(parcelas){

//    case 1:
//        Console.WriteLine($"Prestação de R${compra / parcelas}\n");
//        break;
//    case 2:
//        Console.WriteLine($"Prestação de R${compra / parcelas}\n");
//        break;
//    case 3:
//        Console.WriteLine($"Prestação de R${compra / parcelas}\n");
//        break;
//    default:
//        Console.WriteLine("\nInforme um valor de 1 a 3 no número de parcelas.\n");
//        break;
//}

Console.WriteLine("Informe o número:\n");
var numero = Convert.ToInt32(Console.ReadLine());

switch (numero % 2) {

    case 0:
        Console.WriteLine("\n-- " + numero + " é par.\n");
        break;
    case 1:
        Console.WriteLine("\n-- "+ numero + " é impar.\n");
        break;
    default:
        Console.WriteLine("Informe apenas números inteiros.\n");
        break;
}

Console.WriteLine("Fim do processamento...\n");
Console.ReadKey();
