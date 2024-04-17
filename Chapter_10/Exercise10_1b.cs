Console.WriteLine("Detta menyprogram handlar om beräkningar");
string användarensVal = "";
while (användarensVal != "4")
{
    SkrivMeny();
    användarensVal = Console.ReadLine();
    Console.WriteLine();

    switch (användarensVal)
    {
        case "1":
            MenyAddera(); // call
            break;
        case "2":
            MenySubtrahera(); // call
            break;
        case "3":
            MenyMultiplicera(); // call
            break;
        case "4":
            // Gör ingenting, programmet stängs av
            break;
        default:
            Console.WriteLine("Du valde ett ogiltigt alternativ");
            break;
    }
    Console.WriteLine();
}

// *********** definitions ************

void SkrivMeny()
{
    Console.WriteLine("Välj ett alternativ");
    Console.WriteLine("1. Addera två tal");
    Console.WriteLine("2. Subtrahera två tal");
    Console.WriteLine("3. Multiplicera två tal");
    Console.WriteLine("4. Avsluta programmet");
}

void MenyAddera()
{
    Console.WriteLine("Skriv in två tal");
    double tal1 = double.Parse(Console.ReadLine());
    double tal2 = double.Parse(Console.ReadLine());
    Console.WriteLine($"{tal1} + {tal2} = {tal1 + tal2}");
}

void MenySubtrahera()
{
    Console.WriteLine("Skriv in två tal");
    double tal1 = double.Parse(Console.ReadLine());
    double tal2 = double.Parse(Console.ReadLine());
    Console.WriteLine($"{tal1} - {tal2} = {tal1 - tal2}");
}

void MenyMultiplicera()
{
    Console.WriteLine("Skriv in två tal");
    double tal1 = double.Parse(Console.ReadLine());
    double tal2 = double.Parse(Console.ReadLine());
    Console.WriteLine($"{tal1} * {tal2} = {tal1 * tal2}");
}