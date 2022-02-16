// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

void PrintArr(double[] arr)
{
    foreach (int item in arr)
    {
        Console.Write($"{item} ");
    }
}

double MaxValue(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}

double MinValue(double[] arr)
{
    double min = arr[0];
    for (int j = 1; j < arr.Length; j++)
    {
        if (arr[j] < min)
        {
            min = arr[j];
        }
    }
    return min;
}

double[] arr = { 9.25, 10.65, 13.43, 2.94, 10.65, 11.15 };
double maximumValue = MaxValue(arr);
Console.WriteLine($"Максимальный элемент в массиве = {maximumValue}");
double minimumValue = MinValue(arr);
Console.WriteLine($"Минимальный элемент в массиве = {minimumValue}");
double differenceMaxMin = maximumValue - minimumValue;
Console.WriteLine($"Разница между значениями = {differenceMaxMin}");