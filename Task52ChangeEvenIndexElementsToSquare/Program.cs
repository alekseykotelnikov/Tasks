// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
Console.Clear();
Console.WriteLine();
Random rand = new Random();
int[,] FillArray(int n, int k)
{
    int[,] array = new int[n, k];
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
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] ChangeToSquare(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] = array[i, j] * array[i, j];
            }
        }
    }
    return array;
}
int n = rand.Next(3, 7);
int k = rand.Next(3, 7);
int[,] doubleMass = FillArray(n, k);
Console.WriteLine("Задан двумерный массив следующих элементов:");
PrintArray(doubleMass);
int[,] evenToSquare = ChangeToSquare(doubleMass);
Console.WriteLine("Двумерный массив, элементы у которых оба индекса чётные, становятся квадратами:");
PrintArray(evenToSquare);