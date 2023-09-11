// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 25(0,1,0) 27(0,0,1) 90(0,1,1)
// 34(1,0,0) 41(1,1,0) 26(1,0,1) 55(1,1,1)

Console.Clear();

int[,,] Array3d(int a, int b, int c)
{
    int count = 10;
    int[,,] array = new int[a, b, c];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int x = 0; x < array.GetLength(2); x++)
            {
                
                    array[i, j, x] = count;
                    count += 7;
            }
        }
    }
    return array;
}


void PrintArray3d(int[,,] array3d)
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
                Console.Write($"{array3d[i, j, k],2} ({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}

int[,,] matrix3d = Array3d(2, 2, 2);
PrintArray3d(matrix3d);