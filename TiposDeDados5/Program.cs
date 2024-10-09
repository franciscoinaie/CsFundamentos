Console.WriteLine("DateTime!");

DateTime DataAtual = DateTime.Now;
Console.WriteLine(DataAtual);

//criar uma data especifica utiliza os seguintes termos aaaa/mm/dd

DateTime NovaData = new DateTime(2004, 03, 30);

//definir as horas

DateTime NovaDataHora = new DateTime(2004, 03, 30, 23, 30, 15);

Console.WriteLine(NovaData);
Console.WriteLine(NovaDataHora);