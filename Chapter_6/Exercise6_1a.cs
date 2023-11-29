

double antalKorn = 1;
int antalRutor = 64;
int ruta = 1;

while (ruta <= antalRutor)
{
    Console.WriteLine($"Ruta {ruta} :{antalKorn}");
    antalKorn *= 2;
    ruta++;
}

