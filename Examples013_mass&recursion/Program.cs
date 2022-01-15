//string[,] table = new string[2, 5];  //таблица из строк 
// strig.Empty
//таблица из чисел - матрица 
//int[,] matrix = new int[5, 8];
//первое число - количество строк, второе - количество столбцов
// table [0,0] table [0,1]...table [0,4]
//table [1,0] table [1,1]


// string[,] table = new string[2, 5];
// table[1, 2] = "слово";
// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"__{table[rows, columns]}__");
//     }
// }


//Матрица

// int[,] matrix = new int[3, 4];

// for (int i = 0; i < matrix.GetLength(0); i++)     // getLength(0) - строки 
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)   //getLength (1) - по столбцам
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");

        }
        Console.WriteLine();
    }
}



void FillMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }

    }
}

int[,] matr = new int[3, 5];
PrintMatrix(matr);
Console.WriteLine ();
FillMatrix (matr);
PrintMatrix (matr);
