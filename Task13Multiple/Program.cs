// Выяснить, кратно ли число заданному, если нет, вывести остаток.

void Multiple(int arg1, int arg2)
{
    if (arg1 % arg2 == 0)
    {
        Console.WriteLine("Кратно");
    }
    else
    {
        int result = arg1 % arg2;
        Console.WriteLine($"Остаток {result}");
    }
}

int RandomNumber()
{
    int randomNumber = new Random().Next(10, 100);
    return randomNumber;
}

int specifiedNumber = RandomNumber();
Console.WriteLine($"Заданное число, это {specifiedNumber}");
int checkNumber = RandomNumber();
Console.WriteLine($"Проверяемое число, это {checkNumber}");

Multiple(checkNumber,specifiedNumber);

Console.WriteLine($"{Multiple}");