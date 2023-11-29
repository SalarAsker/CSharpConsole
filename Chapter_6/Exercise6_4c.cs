
int[] tal = new int[10];

for (int i = 0; i < tal.Length; i++)
{
    Console.Write($"Ange ett tal: ");
    tal[i] = int.Parse(Console.ReadLine());
}

// skriver ut inlästa talen
Console.WriteLine($"Inlästa talen");
for (int i = 0;i < tal.Length; i++)
{
    Console.WriteLine(tal[i]);  
}