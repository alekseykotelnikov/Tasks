// Дано число. Проверить кратно ли оно 7 и 23
int randomNumber = new Random() .Next();
Console.WriteLine($"Дано число {randomNumber}");

if (CheckIfModed(randomNumber))
{
    Console.WriteLine($"Число {randomNumber} делится на 7 и на 23");
}
else
{
    Console.WriteLine($"Число {randomNumber} не делится на 7 и на 23");
}

bool CheckIfModed(int randomNumber)
{
    return randomNumber % (7 *23) == 0;
}