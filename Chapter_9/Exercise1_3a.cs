Stack<string> cities = new Stack<string>(); // stack för cities
List<string> inputOrder = new List<string>(); // lista för inmatad ordning

bool running = true;
Console.Clear();
while (running)
{
    Console.WriteLine("\nVälkommen till stackprogrammet för städer!");
    Console.WriteLine("Välj ett alternativ:");
    Console.WriteLine("1: Lägg till en stad (Push)");
    Console.WriteLine("2: Ta bort den senaste staden (Pop)");
    Console.WriteLine("3: Avsluta programmet");

    Console.Write("\nAnge ditt val (1/2/3): ");
    string input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Console.Write("Ange en stad att lägga till: ");
            string city = Console.ReadLine();  
            cities.Push(city); // lägg till i stacken
            inputOrder.Add(city); // lägg till i listan
            break;
        case "2":
            if(cities.Count > 0)
            {
                string removeCity = cities.Pop(); // ta bort från stacken
                inputOrder.Remove(removeCity); // ta bort från listan
                Console.WriteLine($"Tog bort stad {removeCity}");

            }
            break;
        case "3":
            running = false;
            break;
    }
    // skriver ut inmatningsordning
    Console.WriteLine("\nInmatad ordning:");
    foreach (string city in inputOrder) 
    {
        Console.WriteLine(city);
    }
    // skriver ut stacken
    Console.WriteLine("\nPlats på stacken ordning");
    foreach (string city in cities)
    {
        Console.WriteLine(city);
    }

  
}