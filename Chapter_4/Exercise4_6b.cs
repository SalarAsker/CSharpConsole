
const string userId = "petter";
const string password = "abc123";
const string username = "Peter";

Console.Write($"Ange ditt användarnamn? ");
string namn = Console.ReadLine() ;

Console.Write($"Ange ditt lösenord? ");
string losen = Console.ReadLine();

if (userId == namn && password == losen)
{
    Console.WriteLine($"Hello {username}! You have successfully logged in.");
}
else
{
    Console.WriteLine($"Login attempt failed.");
}