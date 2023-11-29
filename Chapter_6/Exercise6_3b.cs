Random rnd = new Random();
int raknare = 0;
while(raknare < 100)
{
    Console.WriteLine($"varv {raknare}: slumptal {rnd.Next(1, 100)}");
    raknare++;
} 