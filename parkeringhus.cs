// parkeringshus
List<string> parkeringsHus = new List<string>(5);

while (true)
{   
    Console.WriteLine("\nVälj ett alternativ:");
    Console.WriteLine("1. Parkera bil");
    Console.WriteLine("2. Visa alla parkerade bilar");
    Console.WriteLine("3. Avsluta");

    // läser in valet
    int val;
    while (!int.TryParse(Console.ReadLine(), out val))
    {
        Console.Write("Felaktigt val, försök igen.: ");
    }

    // parkera bilar
    if (val == 1)
    {
        Console.Clear();
        if (parkeringsHus.Count >= parkeringsHus.Capacity)
        {
            Console.WriteLine($"Parkeringen är full!");
        }
        else
        {
            Console.Write("Ange registreringsnummer: ");
            string regnr = Console.ReadLine();
            parkeringsHus.Add(regnr);
            Console.WriteLine($"Bilen är parkerad!");
        }
    }
    // visar alla bilar
        if (val == 2)
        {
            if (parkeringsHus.Count == 0)
            {
                Console.WriteLine("Inga bilar är parkerade för närvarande.");
            }
            else
            {
                Console.WriteLine("\n***** Parkerade bilar *****");
                foreach (string bil in parkeringsHus)
                {
                    Console.WriteLine(bil);
                }
            }       
        }
        // avlsutar programmet
        if(val == 3)
        {
            break;
        }
}
