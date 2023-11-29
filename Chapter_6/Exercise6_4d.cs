
int[] tarning = new int[1000]; 

// fyll array
Random r = new Random();
for (int i = 0; i < tarning.Length; i++)
{
    tarning[i] = r.Next(1,7);
}

// hitta sexor
int sexor = 0;
for (int i = 0; i < tarning.Length; i++)
{
    if (tarning[i] == 6)
    {
        sexor++;
    }    
}

Console.WriteLine($"Antal sexor: {sexor}");

