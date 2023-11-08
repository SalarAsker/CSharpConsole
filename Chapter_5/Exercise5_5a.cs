
int[,] matrix = { {1,2,3 },
                  {4,5,6 },
                  {7,8,9 } 
                };

Console.WriteLine($"Diagonal sum: {matrix[0,0] + matrix[1,1] + matrix[2, 2]}"); // 1+5+9
Console.WriteLine($"Diagonal sum: {matrix[2,0] + matrix[1, 1] + matrix[0, 2]}"); // 7+5+3