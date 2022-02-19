// Написать программу масштабирования фигуры
Console.Clear();
System.Console.WriteLine();
double[] FillArray()
{
    double[] array = new double[8];
    for (int i = 0; i < 8; i++)
    {
        array[i] = Math.Ceiling(new Random() .NextDouble() * 100);

    }
    Console.WriteLine("Представлены следующие вершины фигуры:");
    Console.WriteLine($" ({array[0]}, {array[1]}) ({array[2]}, {array[3]}) ({array[4]}, {array[5]}) ({array[6]}, {array[7]})");
    return array;
}

void Scaling(double[] arr, double k)
{
    double[] arr2 = new double[8];
    for (int j = 0; j < 8; j++)
    {
        arr2[j] = arr[j] * k;
    }
    Console.WriteLine("После масштабирования вершины фигуры будут:");
    Console.Write($" ({arr2[0]}, {arr2[1]}) ({arr2[2]}, {arr2[3]}) ({arr2[4]}, {arr2[5]}) ({arr2[6]}, {arr2[7]})");
}

double k = 0;
while (k <= 0)
{
    Console.WriteLine("Введите коэффициент для изменения фигуры, больше 0:");
    string numberAStr = Console.ReadLine();
    double.TryParse(numberAStr, out k);
}
Console.WriteLine($"Коэффициент масштабирования = {k}");
double[] coord = FillArray();
Scaling(coord, k);