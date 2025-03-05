 // Skapa två strängar, ord och omväntOrd
        string ord, omväntOrd = "";
        
        // Läs in ordet som ska kontrolleras
        Console.Write("Ange ett ord: ");
        ord = Console.ReadLine();

        // Skapa en stack
        Stack<char> test = new Stack<char>();

        // Placera bokstav för bokstav i ord på stacken
        foreach (char bokstav in ord)
        {
            test.Push(bokstav);
        }

        // Hämta bokstäverna från stacken och lägg dem i omväntOrd
        while (test.Count > 0)
        {
            omväntOrd += test.Pop();
        }

        // Kontrollera om ord och omväntOrd är lika
        if (ord.Equals(omväntOrd, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine($"{ord} är en palindrom!");
        }
        else
        {
            Console.WriteLine($"{ord} är inte en palindrom.");
        }