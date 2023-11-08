string[] personer = {"Jack", "Peter", "Sara" };
double[] loner = { 40000, 42000, 48000 };

Console.WriteLine($"Antal personer i listan {personer.Length}");
int index = 0;
Console.WriteLine($"person i listan {personer.Length}");
Console.WriteLine($"person {index + 1}: {personer[index]} har lön {loner[index++]} ");
Console.WriteLine($"person {index + 1}: {personer[index]} har lön {loner[index++]}");
Console.WriteLine($"person {index + 1}: {personer[index]} har lön {loner[index]}");