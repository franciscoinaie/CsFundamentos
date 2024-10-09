//inicializando array
int[,] a;

//atruibuindo valores
           // 2 linhas , 2 colunas
a = new int[2 , 2];

a[0, 0] = 0;
a[0, 1] = 1;
a[1, 0] = 2;
a[1, 1] = 3;

Console.WriteLine("Array A\n");
Console.WriteLine(a[0, 0]);
Console.WriteLine(a[0, 1]);
Console.WriteLine(a[1,0]);
Console.WriteLine(a[1, 1]);

Console.WriteLine("\n/////////////////////\n");

int[,] b = new int[2, 2] { {20, 25 }, {30, 35 }};

Console.WriteLine("Array B\n");
Console.WriteLine(b[0, 0]);
Console.WriteLine(b[0, 1]);
Console.WriteLine(b[1, 0]);
Console.WriteLine(b[1, 1]);

Console.ReadKey();