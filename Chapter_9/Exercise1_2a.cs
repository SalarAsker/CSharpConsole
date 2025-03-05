List<string> städer = new List<string>();

Console.WriteLine("Du får nu skriva en ett valfritt antal städer. Avsluta med en tom rad");
string nyStad = " ";
while (nyStad != "")
{
    Console.WriteLine("Skriv in en ny stad");
    nyStad = Console.ReadLine();
    if (nyStad != "")
    {
        städer.Add(nyStad);
    }
}

Console.WriteLine("Här är de städer du skrev in");
städer.Sort();

foreach (string stad in städer)
{
    Console.WriteLine(stad);
}