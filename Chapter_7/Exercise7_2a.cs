
string someText = "En BrEd KoRv StÅr På DiSken I BuTiKeN. " +
    "5 DeT Är SoMmAr, OcH SoLeN 8 SkInEr. FaMiLiEn 12 ÅkEr " +
    "TiL StRaNden. BaRfOtA 7 I SaNdEn, De SpElAr VoLlEyBoll. 3 " +
    "SeDAn GrILlAr De 9 FiSk OcH 2 StEaK. EfTeR MaTEn SpElAr De" +
    " KoRtSpEl 4 OcH LaTtJaNs.";
int numDig = 0, numLet = 0, numLow = 0, numUpp = 0;

for (int i = 0; i < someText.Length; i++)
{
   char ch = someText[i];   
    //for digits
    if (char.IsDigit(someText[i]))
    {
        numDig++;
    }
    // for letters
    if (char.IsLetter(someText[i]))
    {
        numLet++;
    }
    // for lowercase letters
    if (char.IsLower(someText[i]))
    {
        numLow++;
    }
    // for uppercase letters
    if (char.IsUpper(someText[i]))
    {
        numUpp++;
    }
}

Console.WriteLine($"Number of digits  {numDig}");
Console.WriteLine($"Number of letters {numLet}");
Console.WriteLine($"Number of lowercase letters {numLow}");
Console.WriteLine($"Number of uppercase letter {numUpp}");