// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

Console.Clear();

void PrintDiffMinMax(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine(arr[i]);
    }
    double difference = arr.Max() - arr.Min();
    System.Console.WriteLine($"Минимальное значение массива {arr.Min()}, максимальное значение массива {arr.Max()}");
    System.Console.WriteLine($"Разница между минимальным и максимальным значениями массива составляет {difference}");
    System.Console.WriteLine();
}



double[] arr = { 9.25, 10.65, 13.43, 2.94, 10.65, 11.15 };
PrintDiffMinMax(arr);
System.Console.WriteLine();