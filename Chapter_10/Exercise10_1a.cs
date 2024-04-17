
// array med 10 platser

int[] talArray = new int[10];

// Anrop metoden FyllArrayn()
FillArray();

// Anrop metoden SkrivaUtArrayn()
SkrivaUtArrayn();

// metods defintion FillArray()
void FillArray()
{
    Random rnd = new Random();
   for (int i = 0; i < talArray.Length; i++)
    {
        talArray[i] = rnd.Next(1,26);
    }
}
// metods definition SkrivaUtArray()
void SkrivaUtArrayn()
{
    for (int i = 0;i < talArray.Length;i++) 
    {
        Console.WriteLine(talArray[i]);
    }
}