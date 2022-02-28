// Найти произведение двух матриц
// Для нахождения произведения умножаем строки первой матрицы на столбцы второй
Console.Clear();
Console.WriteLine();
Random rand = new Random();
int[,] FillArray()
{
    int[,] array = new int[2, 2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(2, 10);
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
    int[,] array = new int[2, 2];
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(0); j++)
        {
            for (int k = 0; k < secondArray.GetLength(1); k++)
            {
                array[i, j] += firstArray[i, k] * secondArray[k, j];
            }
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