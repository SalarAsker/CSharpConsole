// Läs in strängen från användaren
Console.Write("Ange en sträng: ");
string input = Console.ReadLine();

string reversedString = "";
// en omvänd loop
for(int i = input.Length - 1; i>=0; i--)
{
    reversedString += input[i];
}

// Skriv ut den omvända strängen
Console.WriteLine($"Omvänd sträng: {reversedString}");