


int[,] C = { {2,8 },
             {0,9 }
            };

int[,] D = { {5,6 },
             {11,3}
            };

int[,] result = new int[2,2];
if(C.GetLength(0) == D.GetLength((0)) && C.GetLength(1) == D.GetLength(1)){


    result[0, 0] = C[0, 0] - D[0, 0];  
    result[0, 1] = C[0, 1] - D[0, 1];
    result[1, 0] = C[1, 0] - D[1, 0];
    result[1, 1] = C[1, 1] - D[1, 1];

    Console.WriteLine($"result\n{result[0,0]}  {result[0,1]}\n{result[1, 0]}  {result[1, 1]}");
}
else
{
    Console.WriteLine($"Matrices are not equal");
}