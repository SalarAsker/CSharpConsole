
Console.Write($"Ange ett versal: ");
char versal = char.Parse( Console.ReadLine() );

int teckenKod = (int)versal +  32; // hämta tekcenkod och förvandla 
char gemen = (char)teckenKod;
Console.WriteLine(gemen);


