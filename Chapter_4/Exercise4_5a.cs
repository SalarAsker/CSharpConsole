Console.Write($"Hur mycket bensin det finns i tanken? ");
double bensinLiterKvar = double.Parse( Console.ReadLine() );

string meddelande = ""; // tom string
if(bensinLiterKvar < 10)
{
    double antalLiterTanka = 50 - bensinLiterKvar;
    meddelande = $"Tanka {antalLiterTanka} liter.";
    double kostnad = antalLiterTanka * 14.50;
    meddelande += $"\nDet kostar {kostnad} kr.";

}
else
{
    meddelande = $"Kör vidare.";
}

Console.WriteLine(meddelande);