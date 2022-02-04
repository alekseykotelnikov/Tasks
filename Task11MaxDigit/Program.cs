// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int Max(int arg1, int arg2)
{
    int result = arg1;
    if (arg2 > result)
    {
        result = arg2;
    }
    return result;
}

int randomNumber = new Random().Next(10, 100);
Console.WriteLine($"Число из отрезка, это {randomNumber}");
int secondDigit = randomNumber % 10;
Console.WriteLine($"Вторая цифра в Числе, это {secondDigit}");
int firstDigit = randomNumber / 10;
Console.WriteLine($"Первая цифра в Числе, это {firstDigit}");

int maxDigit = Max(firstDigit, secondDigit);
Console.WriteLine($"Наибольшая цифра из числа, это {maxDigit}");