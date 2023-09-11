// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0)/*rows*/; i++) //0 соответствует строкам
    {
        for (int j = 0; j < matrix.GetLength(1)/*columns*/; j++) // 1 соответствует столбцам
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }

    return matrix;
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

void ElementInDescendingOrder(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int x = 0; x < matrix.GetLength(1) - j - 1; x++)
            {
                if (matrix[i, x] < matrix[i, x + 1])
                {
                    (matrix[i, x], matrix[i, x + 1]) = (matrix[i, x + 1], matrix[i, x]);
                }
            }
        }
    }
}

Console.WriteLine("[Задайте двумерный массив из целых чисел M x N.]");
int m = Prompt("Введите количество строк: ");
int n = Prompt("Введите количество столбцов: ");
Console.WriteLine();

Console.WriteLine("[Задайте диапазон элементов.]");
int minNum = Prompt("Введите min: ");
int maxNum = Prompt("Введите max: ");
Console.WriteLine();

Console.WriteLine("[Массив:]");
int[,] array2d = CreateMatrixRndInt(m, n, minNum, maxNum);
PrintMatrix(array2d);
Console.WriteLine();

Console.WriteLine("[Новый массив:]");
ElementInDescendingOrder(array2d);
PrintMatrix(array2d);