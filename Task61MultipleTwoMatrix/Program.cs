// Найти произведение двух матриц
Console.Clear();
Console.WriteLine();
Random rand = new Random();
int[,] FillArray()
{
    int[,] array = new int[3, 3];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(1, 10);
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
int[,] MultipleTwoMatrix(int[,] firstArray, int[,] secondArray)
{
    int[,] array = new int[3, 3];
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            array[i, j] = firstArray[i, j] * secondArray[i, j];
        }
    }
    return array;
}
int[,] firstMatrix = FillArray();
Console.WriteLine("Задан первый двумерный массив следующих элементов:");
PrintArray(firstMatrix);
int[,] secondMatrix = FillArray();
Console.WriteLine("Задан второй двумерный массив следующих элементов:");
PrintArray(secondMatrix);
int[,] multipleMatrix = MultipleTwoMatrix(firstMatrix, secondMatrix);
Console.WriteLine("Произведение двух матриц:");
PrintArray(multipleMatrix);