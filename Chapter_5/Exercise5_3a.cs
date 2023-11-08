int[] dice = new int[6];

Random rnd = new Random();

dice[0] = rnd.Next(1, 7);
dice[1] = rnd.Next(1, 7);
dice[2] = rnd.Next(1, 7);
dice[3] = rnd.Next(1, 7);
dice[4] = rnd.Next(1, 7);
dice[5] = rnd.Next(1, 7);

Console.WriteLine($"{dice[0]}, {dice[1]}, {dice[2]}, " +
    $"{dice[3]}, {dice[4]}, {dice[5]}")