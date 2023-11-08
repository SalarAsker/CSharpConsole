
double[] someNumbers = new double[4];

Console.WriteLine($"Du ska ange fyra flyttal!!");

Console.Write($"Ange ett flyttal: ");
someNumbers[0] = double.Parse(Console.ReadLine());

Console.Write($"Ange ett flyttal: ");
someNumbers[1] = double.Parse(Console.ReadLine());

Console.Write($"Ange ett flyttal: ");
someNumbers[2] = double.Parse(Console.ReadLine());

Console.Write($"Ange ett flyttal: ");
someNumbers[3] = double.Parse(Console.ReadLine());

Console.Write($"{someNumbers[0]} {someNumbers[1]} {someNumbers[2]} {someNumbers[3]}");