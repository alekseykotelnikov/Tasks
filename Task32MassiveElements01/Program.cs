// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран


int[] InitArray()
{
    int[] array = new int[8];
    Random numberRan = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = numberRan.Next(0, 2);
    }
    return array;
}

void PrintThroughtForeachLoop(int[] array)
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
}

int[] array = InitArray();
Console.WriteLine("Массив из 8 элементов, заполненных нулями и единицами:");
PrintThroughtForeachLoop(array);