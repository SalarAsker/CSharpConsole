

int antalDagar = 1;
double dagensLon = 0.01;
double totalBelopp = 0.01;
string val = "";
while (true)
{
    Console.Write($"Önskar belopp? ");
    double onskatBelopp = double.Parse(Console.ReadLine());

    while (totalBelopp < onskatBelopp)
    {
        antalDagar++;
        dagensLon = dagensLon * 2;
        totalBelopp = totalBelopp + dagensLon;
    }
    Console.WriteLine($"Du blir rik efter {antalDagar} dagar");

    // köra om
    Console.Write("En till beräknig? (yes/no)");
    val = Console.ReadLine();
    // villkor för att stoppa loopen
    if (val != "yes")
    {
        break;
    }

}


