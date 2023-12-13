int[,] m =
{
   { 16,9,2,7 },
   {6,3,12,13 },
   {11,14,5,4 },
   {1,8,15,10 }
};
int i, j;
int sum1 = 0, sum2 = 0;

bool isMagiskFyrkant = true; // vi antar att matrisen är magiskt.

if (m.GetLength(0) != m.GetLength(1))
{
    isMagiskFyrkant = false;
}
   
int n = m.GetLength(0);

// kontrollera diagonalerna
for (i = 0; i < n; i++)
{
    sum1 += m[i, i];
    sum2 += m[i, n - i - 1];
}
    if (sum1 != sum2)
    {
        isMagiskFyrkant = false;
    }
   

// kontrollera raderna
for (i = 0; i < n; i++)
{
    for (sum2 = 0, j = 0; j < n; j++)
        sum2 += m[i, j];
    if (sum1 != sum2)
        isMagiskFyrkant = false;
}

// kontrollera kolumnerna
for (j = 0; j < n; j++)
{
    for (sum2 = 0, i = 0; i < n; i++)
        sum2 += m[i, j];
    if (sum1 != sum2)
        isMagiskFyrkant = false;
}


// alla tester avklarade

Console.WriteLine(isMagiskFyrkant);
  