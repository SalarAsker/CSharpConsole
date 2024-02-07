int index = 0;
int count = 0;

string text = "We are living in a yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
string substring = "in";

while ((index = text.IndexOf(substring, index)) != -1)
{
    count++;
    index += substring.Length;
}

Console.WriteLine(count);