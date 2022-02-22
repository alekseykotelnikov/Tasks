// Написать программу масштабирования фигуры
Console.Clear();
Console.WriteLine();
double[] FillArray()
{
    double[] array = new double[8];
    for (int i = 0; i < 8; i++)
    {
        array[i] = Math.Ceiling(new Random().NextDouble() * 100);// Сокращаем до целого числа значение

    }
    return array;
}

double[] Scaling(double[] arr, double k)
{
    double[] arr2 = new double[8];
    for (int j = 0; j < 8; j++)
    {
        arr2[j] = arr[j] * k;
    }
    return arr2;
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
Console.WriteLine("Представлены следующие вершины фигуры:");
Console.WriteLine($" ({coord[0]}, {coord[1]}) ({coord[2]}, {coord[3]}) ({coord[4]}, {coord[5]}) ({coord[6]}, {coord[7]})");
double[] newCoord = Scaling(coord, k);
Console.WriteLine("После масштабирования вершины фигуры будут:");
Console.Write($" ({newCoord[0]}, {newCoord[1]}) ({newCoord[2]}, {newCoord[3]}) ({newCoord[4]}, {newCoord[5]}) ({newCoord[6]}, {newCoord[7]})");
Console.WriteLine();