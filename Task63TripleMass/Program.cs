﻿// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента
Console.Clear();
Console.WriteLine();
Random rand = new Random();
int[,,] TripleMass()
{
    int[,,] array = new int[3, 3, 3];
    int n = rand.Next(10, 50);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = n;
                n++;
            }
        }
    }
    return array;
}
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                Console.Write($" {array[i, j, k]} ");
            }
        }
        Console.WriteLine();
    }
}
void PrintOdd(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                Console.WriteLine($" i = {i}; j = {j}, k = {k} ");
            }
        }
    }
}
int[,,] matrix = TripleMass();
Console.WriteLine("Задан трехмерный массив следующих элементов:");
PrintArray(matrix);
Console.WriteLine("Индексы трехмерного массива построчно:");
PrintOdd(matrix);