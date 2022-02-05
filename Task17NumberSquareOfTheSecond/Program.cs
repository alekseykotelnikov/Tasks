// По двум заданным числам проверять является ли одно квадратом другого
int GetNumber()
{
    int randomNumber = new Random().Next(1, 100);
    return randomNumber;
}

int firstNumber = GetNumber();
Console.WriteLine($"Первое число, это {firstNumber}");
int secondNumber = GetNumber();
Console.WriteLine($"Второе число, это {secondNumber}");

if (firstNumber / secondNumber == secondNumber)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}

if (secondNumber / firstNumber == firstNumber)
{
    Console.WriteLine("Второе число является квадратом первого");
}
else
{
    Console.WriteLine("Второе число не является квадратом первого");
}