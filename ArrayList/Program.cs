using System.Collections;

ArrayList lista = new(5);

//lista.Add("Talia");
//lista.Add(20);
//lista.Add(true);


var lista1 = new ArrayList(5) { "Talia", 20, "Aguiar", true, null };
lista1.Add(5.5);
lista1.Insert(2, "Lulinha");

int[] array1 = {1, 2, 3 };

lista1.AddRange(array1);    
lista1.InsertRange(2 ,array1);    
//ArrayList lista2 = new() {"Talia", 20, true };


lista1.Remove(true);

