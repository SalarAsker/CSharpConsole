// namnlista 
string[] namnlista = {"foo", "boo", "loo",
                      "doo", "", "koo",
                      "", "soo","qoo", "yoo" };

// alla alfabet
string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

// convertera string till en char-array
char[] alphaChars = alpha.ToCharArray();
// resultatet blir som,{'A', 'B', 'C'....}

Random r = new Random();   
for (int i = 0; i < namnlista.Length; i++)
{
    // om det platsen är tomt
    if (namnlista[i] == "")
    {
        // skapa ett nytt namn genom att slumpa tre alphabet
        // från alphaChars array
        string newNamn = "";
        for (int j = 0; j < 3; j++)
        {
            newNamn += alpha[r.Next(0, alphaChars.Length)];
        }
        // stoppa in namnet
        namnlista[i] = newNamn.ToLower(); 
    }
}

// skriver ut alla namn
for(int k= 0; k< namnlista.Length; k++)
{
    Console.WriteLine(namnlista[k]);
}