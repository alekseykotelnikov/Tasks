// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

Console.Clear();

int number = new Random().Next(1, 11);

System.Console.WriteLine($"Количетсов элементов массива: {number}");

double[] FillArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * 100;
    }
    return array;
}

void PrintDiffMinMax(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine(arr[i]);
    }
    double difference = arr.Max() - arr.Min();
    System.Console.WriteLine($"Минимальный элемент массива {arr.Min()}, максимальный элемент массива {arr.Max()}");
    System.Console.WriteLine($"Разница между минимальным и максимальным элементами массива составляет {difference}");
    System.Console.WriteLine();
}


PrintDiffMinMax(FillArray(number));
System.Console.WriteLine();