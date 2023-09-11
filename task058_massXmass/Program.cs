// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3

// Результирующая матрица будет:
// 18 20
// 15 18

﻿// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] ArrayMass(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
            Console.Write($"{array[i, j],2} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("******");
    return array;
}

void ProductOfTwoMatrix(int[,] matr1, int[,] matr2)
{
    int sum = 0;
    int[,] arr = new int[matr1.GetLength(0), matr2.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1); k++)
            {
                sum += matr1[i, k] * matr2[k, j];
            }
            arr[i, j] = sum;
            Console.Write($"{arr[i, j],2} ");
            sum = 0;
        }
        Console.WriteLine();
    }
}

int min = 1; 
int max = 5;

int[,] firstMatrix = ArrayMass(2, 2, min, max);
int[,] secondMatrix = ArrayMass(2, 2, min, max);
Console.WriteLine();

Console.WriteLine("Результирующая матрица будет:");
ProductOfTwoMatrix(firstMatrix, secondMatrix);