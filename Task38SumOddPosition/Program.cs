// Найти сумму чисел одномерного массива стоящих на нечетной позиции
// Вариант, когда позиция в массиве  считается по порядку цифр, а не по индексу.
// Через индекс + 2

Console.Clear();
int[] InitArr()
{
    var arr = new int[6];
    var randomizer = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = randomizer.Next(1, 20);
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

int SumOddPosition(int[] arr)
{
    int sum = 0;
    int i = 0;
    while (i < arr.Length)
    {
        sum = sum + arr[i];
        i = i + 2;
    }
    return sum;
}

int[] initarr = InitArr();
Console.WriteLine("Задан массив чисел: ");
PrintArr(initarr);
Console.WriteLine();
int result = SumOddPosition(initarr);
Console.WriteLine($"Cумма чисел одномерного массива, стоящих на нечетной позиции = {result}");