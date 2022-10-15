// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] array = GetArray(5, 5, 0, 9);
// PrintArray(array);
// Console.WriteLine("В итоге получается вот такой массив: ");
// PrintArray(OrderingRowsArray(array));


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] array = GetArray(5, 5, 0, 9);
// PrintArray(array);
// Console.WriteLine($"Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: {MinSumValueRowsArray(array)} строка");


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] array3D = GetOrderArray3D(2, 2, 2, 10);
PrintArray3D(array3D);


void PrintArray3D(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] GetOrderArray3D(int rows, int columns, int pages, int startValue)
{
    int[,,] result = new int[rows, columns, pages];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < pages; k++)
            {
                startValue++;
                result[i, j, k] = startValue;
            }
        }
    }
    return result;
}

int MinSumValueRowsArray(int[,] array)
{
    int minSum = 0;
    int sum = 0;
    int minRows = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == 0)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                minSum += array[i, j];
            }
        }
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
            if (sum < minSum)
            {
                minSum = sum;
                minRows = i;
            }
        }
        sum = 0;
    }
    return minRows;
}

int[,] OrderingRowsArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, j] < array[i, k])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
    return array;
}

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}