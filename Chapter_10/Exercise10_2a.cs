
Rita(4, '*'); // anrop

Console.WriteLine();

Rita(6, '$'); // anrop

// metodsdefinition
void Rita(int sidlängd, char tecken)
{
    for (int i = 1; i <= sidlängd; i++)
    {
        for (int j = 0; j < i; j++)
        {
            Console.Write(tecken);
        }
        Console.WriteLine();
    }
}