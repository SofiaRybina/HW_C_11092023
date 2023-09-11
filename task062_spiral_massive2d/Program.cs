// // Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

// // Например, на выходе получается вот такой массив:
// // 01 02 03 04
// // 12 13 14 05
// // 11 16 15 06
// // 10 09 08 07

// Console.Clear();

// int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0)/*rows*/; i++) //0 соответствует строкам
//     {
//         for (int j = 0; j < matrix.GetLength(1)/*columns*/; j++) // 1 соответствует столбцам
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }
//     }

//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("|");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j],5}"); //5 это длина строки вместе с выводимым числом
//         }
//         Console.WriteLine("|");
//     }
// }

// Console.WriteLine("[Массив 4*4:]");

// int[,] array2d = CreateMatrixRndInt(m, n, minNum, maxNum);
// PrintMatrix(array2d);
// Console.WriteLine();

int[,] SpiralArrayFilling(int m, int n)
{
    int[,] arr = new int[m, n];
    int count = 1;
    int round = 0;
    while (true)
    {
        for (int i = 0 + round; i < arr.GetLength(1) - 1 - round; i++)
        {
            arr[0 + round, i] = count;
            count += 1;
            if(count > m * n) return arr;
        }
        for (int j = 0 + round; j < arr.GetLength(0) - 1 - round; j++)
        {
            arr[j, m - 1 - round] = count;
            count += 1;
            if(count > m * n) return arr;
        }
        for (int i = arr.GetLength(1) - 1 - round; i > 0 + round; i--)
        {
            arr[arr.GetLength(1) - 1 - round, i] = count;
            count += 1;
            if(count > m * n) return arr;
        }
        for (int j = arr.GetLength(0) - 1 - round; j > 0 + round; j--)
        {
            arr[j, 0 + round] = count;
            count += 1;
            if(count > m * n) return arr;
        }
        round += 1;
    }
    return arr;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}"); //5 это длина строки вместе с выводимым числом
        }
        Console.WriteLine("|");
    }
}

int[,] array = SpiralArrayFilling(4, 4);
Console.WriteLine();
PrintMatrix(array);