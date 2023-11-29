string[] namnlista = {"foo", "boo", "loo",
                      "doo", "", "koo",
                      "", "soo","qoo", "yoo" };

int sakna = 0;

for (int i = 0; i < namnlista.Length; i++)
{
    if (namnlista[i] == "")
    {
        sakna++;
    }
}

Console.WriteLine($"Personer saknar: {sakna}");