Console.Write($"Ange din ålder? ");
int alder = int.Parse( Console.ReadLine() );

if( alder > 15 && alder < 65)
{
    Console.WriteLine($"Resan kostar 20 kronor");
}
else
{
    Console.WriteLine($"Resan kostar 10 kronor");
}