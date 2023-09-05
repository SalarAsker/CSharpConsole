Console.Write($"Ange ett decimaltal? ");
double decimalTal = double.Parse( Console.ReadLine() );

Console.WriteLine($"Avrundat till närmaste talet {Math.Round(decimalTal)}");
Console.WriteLine($"Avrundat neråt {Math.Floor(decimalTal)}");
Console.WriteLine($"Avrundat uppåt {Math.Ceiling(decimalTal)}");