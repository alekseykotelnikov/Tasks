// Пробуем цикл foreach

int[] InitArray()
{
    int[] array = new int[25];
    Random numberRan = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = numberRan.Next(10, 100);
    }
    return array;
}

void PrintThroughtForLoop(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void PrintThroughtForeachLoop(int[] array)
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
}

int[] array = InitArray();

Console.WriteLine("Через цикл for: ");
PrintThroughtForLoop(array);

Console.WriteLine();

Console.WriteLine("Через цикл foreach: ");
PrintThroughtForeachLoop(array);