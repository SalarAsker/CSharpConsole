int tiotusental = 76650;
int hundratal = tiotusental%1000; // hämtar ut 650
int mellenSkillnad = 1000 - hundratal; // 1000 - 650

int avrundt = tiotusental + mellenSkillnad;

Console.WriteLine(avrundt);