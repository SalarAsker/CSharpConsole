Console.Write($"Antal dagar? ");
int antalDagar = int.Parse( Console.ReadLine() );

Console.Write($"Pris per dag? ");    
double dagsPris = double.Parse( Console.ReadLine() ); 

// beräkna priset
double totalPris = antalDagar * dagsPris;

Console.WriteLine($"Total Pris: {totalPris}");
