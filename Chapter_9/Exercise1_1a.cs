// Skapa en ArrayList och lägg till olika typer av element
using System.Collections;

ArrayList lista = new ArrayList();
lista.Add(42);               // int
lista.Add(3.14);             // double
lista.Add("Hej!");           // string
lista.Add(true);             // bool
lista.Add('A');              // char
lista.Add(DateTime.Now);     // DateTime
lista.Add(1000L);            // long
lista.Add(2.718f);           // float
lista.Add(new int[] { 1, 2 }); // array av int
lista.Add(null);             // null-värde

// Loopar igenom listan och skriver ut elementets värde och typ
Console.WriteLine("Elementens värde och datatyp:");
foreach (var element in lista)
{
    if (element != null)
    {
        Console.WriteLine($"Värde: {element}, Typ: {element.GetType()}");
    }
    else
    {
        Console.WriteLine("Värde: null, Typ: null");
    }
}