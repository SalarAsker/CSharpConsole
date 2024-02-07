Console.Write($"Ange en e-post: ");
string input = Console.ReadLine(); // abc@example.com

char[] separators = new char[] {'.','@'};


string[] parts = input.Split(separators);

foreach (string part in parts)
{
    Console.WriteLine(part);
}
