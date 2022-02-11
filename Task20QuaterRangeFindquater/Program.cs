// Задать номер четверти, показать диапазоны для возможных координат

void QuaterNumber(int number, string str1, string str2)
{
    if (number == 1)
    {
        str1 = "I";
        str2 = "x > 0; y > 0";
        Console.WriteLine($"Четверть номер {str1} имеет следующий диапазон для х и у: {str2} ");
    }
    if (number == 2)
    {
        str1 = "II";
        str2 = "x < 0; y > 0";
        Console.WriteLine($"Четверть номер {str1} имеет следующий диапазон для х и у: {str2} ");
    }
    if (number == 3)
    {
        str1 = "III";
        str2 = "x < 0; y < 0";
        Console.WriteLine($"Четверть номер {str1} имеет следующий диапазон для х и у: {str2} ");
    }
    if (number == 4)
    {
        str1 = "IV";
        str2 = "x > 0; y < 0";
        Console.WriteLine($"Четверть номер {str1} имеет следующий диапазон для х и у: {str2} ");
    }
}


int quaterNumberInt = new Random().Next(1, 5);
Console.WriteLine($"Задана четверть номер {quaterNumberInt}");
string range = " ";
string quaterNumberStr = " ";
QuaterNumber(quaterNumberInt, quaterNumberStr, range);