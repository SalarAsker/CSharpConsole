string fnamn;
string enamn;
string antalBarn;

Console.Write($"Ange ditt fnamn? ");
fnamn = Console.ReadLine();

Console.Write($"Ange ditt enamn? ");
enamn = Console.ReadLine();

Console.Write($"Antal barn? ");
antalBarn = Console.ReadLine();

Console.WriteLine($"{fnamn} {enamn} har {antalBarn} barn");