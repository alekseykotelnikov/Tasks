// SВозведите число А в натуральную степень B используя цикл

int GetNumber()
{
    int num = new Random().Next(1, 5);
    return num;
}

int number = GetNumber();
int degree = GetNumber();
int result = number;

for (int i = 1; i < degree; i++)
{
    result = result * number;
}

Console.WriteLine($"Число {number} в {degree} степени = {result}");
