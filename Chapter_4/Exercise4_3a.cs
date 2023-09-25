
        int a = 1;
        int b = 2;
        int c = 3;

        Console.WriteLine(1 < 2 && 5 > 4); // ?
        Console.WriteLine(1 == 2 && 1 < 2); // ?
        Console.WriteLine(1 == 2 || 2 == 2); // ?
        Console.WriteLine(3 <= 4 && 3 >= 4); // ?
        Console.WriteLine(2 < 1 || 2 == 0); // ?
        Console.WriteLine(5 < 5 && 5 > 5); // ?
        Console.WriteLine(5 < 5 || 5 > 5); // ?
        Console.WriteLine(a < b && a > b); // ?
        Console.WriteLine(a < b || a > b); // ?
        Console.WriteLine(a < c && b > c); // ?
        Console.WriteLine(a == b && a < c); // ?
        Console.WriteLine(b <= c && b >= a); // ?
    
