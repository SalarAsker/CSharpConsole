
//anrop
string result = GetErrorMessage();

Console.WriteLine(result);

// Man kan också anropa metoden i WriteLine()
// Console.WriteLine(GetErrorMessage();

/*******************/
// definition
// returtypen är string
string GetErrorMessage()
{
    string msg = "You have error in your program!";
    return msg; // returnera texten
    
    // Alternativt: Du kan också skriva på det sättet
    // return "You have error in your program";
}