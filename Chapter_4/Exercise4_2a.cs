Console.Write($"Vad kostar varan? ");
double varansPris = double.Parse( Console.ReadLine() );

Console.Write($"Hur mycket pengar har du? ");
double minaPengar = double.Parse(Console.ReadLine());

bool kanKopa = varansPris <= minaPengar;

Console.WriteLine($"Jag har råd: {kanKopa}");