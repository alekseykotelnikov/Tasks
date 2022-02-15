// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

Console.Clear();
int[] InitArr()
{
    var arr = new int[10];
    var randomizer = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = randomizer.Next(100, 1000);
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

void OddEvenNumbers(int[]arr)
{
    int odd = 0;
    int even = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
        {
            even = even + 1;
        }
        else
        {
            odd = odd +1;
        }
    }
    Console.WriteLine($"Количество четных чисел = {even}, количество нечетных чисел = {odd}");
}

int[] initarr = InitArr();
Console.WriteLine("Задан массив чисел: ");
PrintArr(initarr);
Console.WriteLine();

OddEvenNumbers(initarr);