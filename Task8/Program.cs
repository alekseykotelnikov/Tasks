// Показать четные числа от 1 до N
int number = 0;
while (number == 0 || number == 1)
{
    Console.Write("Введите предельное число больше 1 ");
    string numberStr = Console.ReadLine();
    int.TryParse(numberStr, out number);
}

for (int i = 1; i <= number; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"Четное число от 1 до {number}, это {i}");
    }
}

