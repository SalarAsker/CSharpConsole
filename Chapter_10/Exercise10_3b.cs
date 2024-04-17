
//anrop 
// tar emot en array vid varje anrop
int[] result = GetArray();

// skriver ut

foreach (int tal in result)
{
    Console.WriteLine(tal);
}


/*******************/
// definition
// returtypen är en array
int[] GetArray()
{
    int[] randomTal = new int[10]; // skapar en array

    Random rnd = new Random();

    // fylla arrayn
    for (int i = 0; i < randomTal.Length; i++)
    {
        randomTal[i] = rnd.Next(1, 101);
    }

    return randomTal; // return array
}