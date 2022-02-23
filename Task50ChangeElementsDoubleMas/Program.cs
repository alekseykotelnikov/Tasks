// В двумерном массиве n×k заменить четные элементы на противоположные
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
            array[i, j] = rand.Next(1, 100);
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
int[,] ChangeElements(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] % 2 == 0)
            {
                array[i, j] = array[i, j] * -1;
            }
        }
    }
    return array;
}
int n = rand.Next(2, 5);
int k = rand.Next(2, 5);
int[,] doubleMass = FillArray(n, k);
Console.WriteLine("Задан двумерный массив следующих элементов:");
PrintArray(doubleMass);
int[,] changeElementsMass = ChangeElements(doubleMass);
Console.WriteLine("Двумерный массив с замененными четными элементами на противоположные:");
PrintArray(changeElementsMass);