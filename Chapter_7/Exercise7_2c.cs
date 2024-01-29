Console.Write("Ange ett aritmetiskt uttryck: ");
string uttryck = Console.ReadLine();

int parenthesBalans = 0;

foreach (char tecken in uttryck)
{
    if (tecken == '(')
    {
        parenthesBalans++;
    }
    else if (tecken == ')')
    {
        parenthesBalans--;
    }
}

if (parenthesBalans == 0)
{
    Console.WriteLine("Parenteserna är korrekt placerade.");
}
else
{
    Console.WriteLine("Parenteserna är inte korrekt placerade.");
}
   