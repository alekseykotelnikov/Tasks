﻿// Определить количество цифр в числе

int GetNumber()
{
    int randomNumber = new Random().Next(100, 10000);
    return randomNumber;
}

int number = GetNumber();
Console.WriteLine(number);

int countOfDigit = 0;

while (number != 0)
{
    number = number / 10;
    countOfDigit++;
}

Console.WriteLine($"Количество цифр в числе будет {countOfDigit}");