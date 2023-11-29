
Random rnd = new Random();

for (int i = 0; i < 100; i++)
{
    Console.WriteLine($"varv {i}: slumptal {rnd.Next(1,100)}");
}
