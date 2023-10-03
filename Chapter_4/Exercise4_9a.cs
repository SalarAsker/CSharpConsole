

Console.Write($"Ange tal1? ");
double tal1 = double.Parse(Console.ReadLine());

Console.Write($"Ange tal2? ");
double tal2 = double.Parse(Console.ReadLine());

Console.Write($"Ange ett räknesätt (+,-,*,/)? ");
string raknesatt = Console.ReadLine();

switch (raknesatt)
{
    case "+":
        Console.WriteLine($"Addition: {tal1} + {tal2} = {tal1 + tal2}");
        break;
    case "-":
        Console.WriteLine($"Subtraktion: {tal1} - {tal2} = {tal1 - tal2}");
        break;
    case "*":
        Console.WriteLine($"Multiplikation: {tal1} * {tal2} = {tal1 * tal2}");
        break;
        case "/":
        Console.WriteLine($"Division: {tal1} / {tal2} = {tal1 / tal2}");
        break;
        default:
        Console.WriteLine($"Okänt räknesätt");
        break; 
}



