// Найти сумму чисел от 1 до А

int InPut(string message)
{
    Console.WriteLine(message);
    string numStr = Console.ReadLine();
    int numInt = int.Parse(numStr);
    return numInt;
}

int number  = InPut("Введите предельное число");

int sum = 0;

for (int i = 1; i <= number; i ++)
{
    sum = sum + i;
}

Console.WriteLine($"Сумма будет = {sum}");