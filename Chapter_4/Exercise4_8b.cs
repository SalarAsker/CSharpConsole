/*
Tillverka ett enkelt miniräknarprogram. Programmet läser in två flyttal 
'och ett räknesätt (+ - * /). Programmet ska sedan visa resultatet. 
Använd if else-if konstruktion.
*/



Console.Write($"Ange tal1? ");
double tal1 = double.Parse(Console.ReadLine());

Console.Write($"Ange tal2? ");
double tal2 = double.Parse(Console.ReadLine());

Console.Write($"Ange ett räknesätt (+,-,*,/)? ");
string raknesatt = Console.ReadLine();

if(raknesatt == "+")
{
    Console.WriteLine($"Addition: {tal1} + {tal2} = {tal1 + tal2}");
}
else if(raknesatt == "-")
{
    Console.WriteLine($"Subtraktion: {tal1} - {tal2} = {tal1 - tal2}");
}
else if(raknesatt == "*")
{
    Console.WriteLine($"Multiplikation: {tal1} * {tal2} = {tal1 * tal2}");

}
else if (raknesatt == "/")
{
    Console.WriteLine($"Division: {tal1} / {tal2} = {tal1 / tal2}");
}
else
{
    Console.WriteLine($"Okänt räknesätt");
}
