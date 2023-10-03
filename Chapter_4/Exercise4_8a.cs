/*

Vid köp av ett spel är priset 50,99 kr. Då antalet spel passerar gränserna 5, 10 och 15 
ges rabatt med 5%, 10% respektive 15% på hela köpet. Tillverka ett program som frågar 
efter önskat antal spel och som beräknar priset för inköpet.

*/

Console.Write($"Antal spel att köpa ? ");
int antalSpel = int.Parse(Console.ReadLine());
const double prisPerSpel = 55.99;

double rabatt = 0;

if( antalSpel < 5)
{
    rabatt = 0;

}else if( antalSpel < 10)
{
    rabatt = 5;

}else if(antalSpel < 15)
{
    rabatt = 10;

}else
{
    rabatt = 15;
}

double pris = antalSpel * prisPerSpel * (1-rabatt/100);
Console.WriteLine($"Kostnaden för {antalSpel} spel är {pris} kronor");