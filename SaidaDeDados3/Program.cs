Console.WriteLine("Conversões de Tipos ##\n");

int varint = 100; 

//int possui 4 bytes
//enquanto double possui 8 bytes

//conversão implicita
double varDouble = varint;
Console.WriteLine(varDouble);

//conversao explicita
double varDouble2 = 12.3456;

int varint2 = (int)varDouble2;
Console.WriteLine(varint2);

//aqui ele ira dividir e o resultado sera inteiro e nao float
int num = 10;
int num2 = 4;

//para tranformar em float adicione abaixo o (float)
float resultado = (float) num / num2;

Console.WriteLine(resultado);

Console.ReadLine();