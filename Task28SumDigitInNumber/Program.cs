// Подсчитать сумму цифр в числе
int number = 0;
while (number == 0)
{
    Console.Write("Введите положительное число, чтобы не спорить о знаке \" - \"  ");
    string numberAStr = Console.ReadLine();
    int.TryParse(numberAStr, out number);
    if (number < 0)
    {
         Console.WriteLine("Просили же ввести положительное число, знак минус не будет учтен ");
        number = number * -1;
    }
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