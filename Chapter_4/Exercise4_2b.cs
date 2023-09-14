long personNummer = 8009276742;

long removeLast = personNummer / 10; // den blir 800927674
long takeOutLast = removeLast % 10; // det blir 2

Console.WriteLine($"Personnumret {personNummer} hör till!");

bool kvinna = takeOutLast % 2 == 0; // för kvinnor
bool man = takeOutLast % 2 != 0;    // för män

Console.WriteLine($"Man: {man}");
Console.WriteLine($"Kvinna: {kvinna}");