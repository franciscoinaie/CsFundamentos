Console.WriteLine("Hello, World!");

Produto p1 = new();

p1.Nome = "Caderno 15 matérias";
p1.Preco = 30.00;
p1.Desconto = 10.00;
p1.EstoqueMinimo = 4;
p1.PrecoFinal = p1.Preco - p1.Desconto;

p1.Exibir();


Console.ReadKey();
