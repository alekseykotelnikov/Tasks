// Написать программу, которая упорядочивает по убыванию элементы каждой строки двумерной массива.
Console.Clear();
Console.WriteLine();
Random rand = new Random();
int[,] FillArray()
{
    int[,] array = new int[5, 5];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(10, 100);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] SortArray(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0) - 1; i++)
        {
            int maxPosition = i;
            for (int k = i + 1; k < array.GetLength(0); k++)
            {
                if (array[k, j] > array[maxPosition, j])
                {
                    maxPosition = k;
                }
            }
            int temporary = array[i, j];
            array[i, j] = array[maxPosition, j];
            array[maxPosition, j] = temporary;
        }
    }
    return array;
}
int[,] doubleMass = FillArray();
Console.WriteLine("Задан двумерный массив следующих элементов:");
PrintArray(doubleMass);
int[,] newDoubleMass = SortArray(doubleMass);
Console.WriteLine("Отсортированный массив будет следующим:");
PrintArray(newDoubleMass);