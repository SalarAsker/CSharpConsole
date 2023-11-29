string[] arsenal = { "blue", "white", "pink" };
string[] manchester = { "red", "white" };
string[] madrid = { "white", "yellow", "black" };
string[] barcelona = { "red", "blue" };

string[][] leagueShirtColor = new string[4][];

leagueShirtColor[0] = arsenal;
leagueShirtColor[1] = manchester;
leagueShirtColor[2] = madrid;
leagueShirtColor[3] = barcelona;

/*

Man även initiera en jagged array i samband med deklarationen, men då måste  man uttryckligen
skapa ett ny array för varje komponent. Som till exempel, 

string[][] leagueShirtColor = {
                                new string[]{ "blue", "white", "pink" },
                                new string[]{ "red", "white"},
                                new string[]{ "white", "yellow", "black" },
                                new string[] { "red","blue"}

                                };

 */
