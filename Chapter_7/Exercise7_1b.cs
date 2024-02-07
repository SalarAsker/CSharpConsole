
Console.Write($"Ange ett versal: ");
char versal = char.Parse( Console.ReadLine() );
// här i if-satsen under kommer programmet själv
// hämta teckenkoden till versalen
if(versal >= 65 && versal <=90){
    int teckenKod = (int)versal +  32;
    char gemen = (char)teckenKod;
    Console.WriteLine(gemen);

}else{
    Console.WriteLine($"Ogiltigt inmatning.");
}
