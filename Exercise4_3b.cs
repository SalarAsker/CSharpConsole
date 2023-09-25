int treTalRaknare = 0;

Console.Write($"ange tal{++treTalRaknare}: ");
int tal1 = int.Parse(Console.ReadLine());

Console.Write($"ange tal{++treTalRaknare}: ");
int tal2 = int.Parse(Console.ReadLine());

Console.Write($"ange tal{++treTalRaknare}: ");
int tal3 = int.Parse(Console.ReadLine());

bool ordning = tal1 <= tal2 && tal2 <= tal3;

Console.WriteLine($"Talen är i ordingsöljd: {ordning}");