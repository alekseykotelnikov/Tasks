// Определить сколько чисел больше 0 введено с клавиатуры
Console.Clear();
Console.WriteLine();

int numberTry = 5;
int count = 0;
while (numberTry > 0)
{
    Console.Write("Введите число ");
    string valueStr = Console.ReadLine();
    if (int.TryParse(valueStr, out int valueInt))
    {
        if (valueInt > 0)
        {
            count++;
        }
        numberTry--;
    }
    else
    {
        Console.Write("");

    }
}
Console.WriteLine($"Количество чисел больше 0, введенных с клавиатуры = {count}");
