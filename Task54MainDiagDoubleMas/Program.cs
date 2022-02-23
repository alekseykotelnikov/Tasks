// В матрице чисел найти сумму элементов главной диагонали
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
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void SumMatrixDiag(int[,] array)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                result = result + array[i, j];
                Console.WriteLine($"Число {array[i, j]} будет входить в сумму главной диагонали");
            }
        }
    }
    Console.WriteLine($"Сумма всех элементов, входящих в главную диагональ = {result}");
}
int[,] doubleMass = FillArray();
Console.WriteLine("Задан двумерный массив следующих элементов:");
PrintArray(doubleMass);
SumMatrixDiag(doubleMass);