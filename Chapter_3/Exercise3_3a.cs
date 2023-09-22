Console.Write($"Tänk på ett tal ?! ");
int tanktTal  = int.Parse(Console.ReadLine());

int tal = tanktTal;

tal += 1;
tal *= 2;
tal -= 6;
tal /= 2;
tal += 3;
tal -= tanktTal;

Console.WriteLine($"Nu har du fått talet {tal} ");