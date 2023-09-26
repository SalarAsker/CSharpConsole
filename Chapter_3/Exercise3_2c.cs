Console.Write($"Ange dagens mätarställning? ");
double dagensMatarstallning = double.Parse( Console.ReadLine() );

Console.Write($"Ange mätarställning för ett år sedan? ");
double arMatarstallning = double.Parse(Console.ReadLine());

Console.Write($"Ange bensin förbrukning? ");
double bensinForbrukning = double.Parse(Console.ReadLine());

double antalMil = dagensMatarstallning - arMatarstallning;

double forbrukning = antalMil / bensinForbrukning;

Console.WriteLine($"Bilen har gått {antalMil} mil.");
Console.WriteLine($"Bilen har förbrukat {forbrukning.ToString("0.00")} lit bensin per mil.");
