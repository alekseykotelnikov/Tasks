// Написать программу замену элементов массива на противоположные
Console.Clear();
int[] InitArr()
{
    var arr = new int[10];
    var randomizer = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = randomizer.Next(1, 100);
    }
    return arr;
}

void PrintArr(int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write($"{item} ");
    }
}

int[] ChangeElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
    }
    return arr;
}

int[] initarr = InitArr();
Console.WriteLine("Задан массив чисел: ");
PrintArr(initarr);
int[] newarr = ChangeElements(initarr);
Console.WriteLine();
Console.WriteLine("Массив с противоположными элементами: ");
PrintArr(newarr);