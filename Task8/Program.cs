// Показать четные числа от 1 до N

Console.Write("Введите предельное число ");
string numberStr = Console.ReadLine();
if (int.TryParse(numberStr, out int numberInt))
{
    for (int i = 1; i < numberInt; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine($"Четное число от 1 до {numberInt}, это {i}");
        }
    }
}
else
{
    Console.WriteLine("Введите  ");
}