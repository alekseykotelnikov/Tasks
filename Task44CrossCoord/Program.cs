// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
Console.Clear();
Console.WriteLine();
double GetNumber()
{
    double number = new Random().Next(1, 10);
    return number;
}

double k1 = GetNumber();
double b1 = GetNumber();
double k2 = GetNumber();
double b2 = GetNumber();
if (k1 - k2 != 0)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = (k1 * x) + b1;
    Console.WriteLine($"Заданы переменные:");
    Console.WriteLine($" k1 = {k1};\n k2 = {k2};\n b1 = {b1};\n b2 = {b2}");
    Console.WriteLine($"Точка пересечения двух прямых, это x = {x}, y = {y}");
}
else
{
    Console.WriteLine($"Запустите программу заново!");
}