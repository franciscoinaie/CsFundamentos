//Declarando um array
int[] numeros;

//alocando na memoria
//tamanho do array é 10
numeros = new int[10] { 1,2,3,4,5,6,7,8,9,10 };

//outra forma de declarar arrays ja inicializando
string[] Talia = new string[5] {"Talia","amor","da","minha","vida!" };

//simplificando mais a declaração de um array
string[] Talia1 = new string[] {"Talia","amor","da","minha","vida!" };

//o compilador ja entende que o tipo é string e o seu tamanho é 5
string[] Talia2 = {"Talia","amor","da","minha","vida!" };

Console.WriteLine(Talia2[0]);
Console.WriteLine(Talia2[1]);
Console.WriteLine(Talia2[2]);
Console.WriteLine(Talia2[3]);
Console.WriteLine(Talia2[4]);