
            Console.WriteLine("Select an option:");
            Console.WriteLine("a. Display the current date and time.");
            Console.WriteLine("b. Add days to the current date and time.");
            Console.WriteLine("c. Subtract days from the current date and time.");
            Console.WriteLine("d. Check if a given year is a leap year.");
           Console.Write("Enter your choice: ");

            string choice = Console.ReadLine().ToLower();

            if (choice == "a")
            {
                // Display the current date and time
                DateTime currentDateTime = DateTime.Now;
                Console.WriteLine("Current date and time: " + currentDateTime);
            }
            else if (choice == "b")
            {
                // Add days to the current date and time
                Console.Write("Enter the number of days to add: ");
                if (int.TryParse(Console.ReadLine(), out int daysToAdd))
                {
                    DateTime newDateTime = DateTime.Now.AddDays(daysToAdd);
                    Console.WriteLine("Updated date and time: " + newDateTime);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number of days.");
                }
            }
            else if (choice == "c")
            {
                // Subtract days from the current date and time
                Console.Write("Enter the number of days to subtract: ");
                if (int.TryParse(Console.ReadLine(), out int daysToSubtract))
                {
                    DateTime newDateTime = DateTime.Now.AddDays(-daysToSubtract);
                    Console.WriteLine("Updated date and time: " + newDateTime);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number of days.");
                }
            }
           
            else if (choice == "d")
            {
                // Check if a given year is a leap year
                Console.Write("Enter a year: ");
                if (int.TryParse(Console.ReadLine(), out int year))
                {
                    bool isLeapYear = DateTime.IsLeapYear(year);
                    if (isLeapYear)
                    {
                        Console.WriteLine(year + " is a leap year.");
                    }
                    else
                    {
                        Console.WriteLine(year + " is not a leap year.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid year.");
                }
            }
           
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid option.");
            }

            Console.WriteLine();
        
