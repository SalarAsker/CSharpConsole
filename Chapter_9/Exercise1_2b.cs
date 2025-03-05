List<char> tecken = new List<char>();

Console.Write("Skriv in några ord: ");
string text = Console.ReadLine();

for (int i = 0; i < text.Length; i++)
{
    if (char.IsLetter(text[i]))
    {
        tecken.Add(text[i]);
    }
}


Console.WriteLine("Här är alla tecken som fanns i dina ord");

for (int i = 0; i < tecken.Count; i++)
{
    Console.WriteLine(tecken[i]);
}