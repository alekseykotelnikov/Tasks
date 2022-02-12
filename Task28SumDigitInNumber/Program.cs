// Подсчитать сумму цифр в числе
int number = -1;
while (number < 0)
{
    Console.Write("Введите положительное число, чтобы не спорить о знаке \" - \"  ");
    string? numberAStr = Console.ReadLine();
    int.TryParse(numberAStr, out number);
}

Console.Write($"Сумма цифр в числе {number} = ");
int sum = 0;
while (number > 0)
{
    int digit = number % 10;
    sum = sum + digit;
    number = number / 10;
}
Console.WriteLine($"{sum}");