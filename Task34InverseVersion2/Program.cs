// Написать программу замену элементов массива на противоположные
//Вариант, где противоположными являются первое/последнее число и т.д.
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

void InverseMassive(int[] arr)
{
    for (int i = arr.Length - 1; i >= 0; i--)
    Console.Write($"{arr[i]} ");
}

int[] numbersMassive = InitArr();
Console.WriteLine("Задан массив: ");
PrintArr(numbersMassive);
Console.WriteLine("Инверсия массива будет следующей: ");
InverseMassive(numbersMassive);