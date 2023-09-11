// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void RowWithMinSumOfElement(int[,] matrix)
{
    int row = matrix.GetLength(0);
    int column = matrix.GetLength(1);
    int[] newArray = new int[matrix.GetLength(0)];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            newArray[i] += matrix[i, j];
        }
        Console.WriteLine($"Сумма {i + 1} строки = {newArray[i]}");
    }

    int numOfMinRow = 0;

    for (int i = 1; i < newArray.Length; i++)
    {
        if (newArray[i] < newArray[numOfMinRow])
        {
            numOfMinRow = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Строка с минимальной суммой -> {numOfMinRow + 1}");
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

RowWithMinSumOfElement(array2d);

