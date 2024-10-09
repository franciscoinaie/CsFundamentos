Console.WriteLine(" ### Constantes ###\n");

//calculo da area e preimetro do circulo

double raio, perimetro, area;
const double PI = 3.14;

Console.WriteLine("Informe o raio do circulo:\n");
raio = Convert.ToDouble(Console.ReadLine());

perimetro = 2 * PI * raio;
//usando as constantes math/ pow é elevar no caso ao quadrado
area = Math.PI * Math.Pow(raio,2);

Console.WriteLine($"O valor do perimetro é {perimetro}\ne o valor da area é {area}");

Console.ReadKey();