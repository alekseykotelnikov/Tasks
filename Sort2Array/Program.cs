// Sort
Console.Clear();
Console.WriteLine();
Random numberRan = new Random();

int[] InitArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = numberRan.Next(10, 100);
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

string SortArray(int[] array)
{
    string arrayB = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            arrayB += $"{array[i]} ";
        }
    }
    return arrayB;
}

int CountEvenNumbers(int[] array)   // Подсчет количества четных элементов исходного массива
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] CreateEvenNumbersArray(int count, int[] firstArray)  // Создание нового массива из четных элементов исходного массива
{
    int[] arrayEven = new int[count];
    int j = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i] % 2 == 0)
        {
            arrayEven[j] = firstArray[i];
            j++;
        }
    }
    return arrayEven;
}

int[] array = InitArray();
Console.WriteLine("Через цикл foreach: ");
PrintThroughtForeachLoop(array);
string arrayB = SortArray(array);
Console.WriteLine();
Console.WriteLine("Отсортированный: ");
Console.WriteLine(arrayB);