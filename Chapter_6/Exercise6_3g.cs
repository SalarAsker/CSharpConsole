Console.Write($"Loop starts at?");
int start = int.Parse(Console.ReadLine());


Console.Write($"Loop ends at?");
int ends = int.Parse(Console.ReadLine());

Console.Write($"Loop stage?");
int stage = int.Parse(Console.ReadLine());
// custom loop
for (int i = start; i < ends; i = i + stage)
{
    Console.WriteLine(i);
}