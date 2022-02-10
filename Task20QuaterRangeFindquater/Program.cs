// Задать номер четверти, показать диапазоны для возможных координат

int quaterNumberInt = new Random().Next(1, 5);
Console.WriteLine($"Задана четверть номер {quaterNumberInt}");
string range = " ";
string quaterNumberStr = " ";

void QuaterNumber(int number)
{
    if (quaterNumberInt == 1)
    {
        quaterNumberStr = "I";
        range = "x > 0; y > 0";
    }
    if (quaterNumberInt == 2)
    {
        quaterNumberStr = "II";
        range = "x < 0; y > 0";
    }
    if (quaterNumberInt == 3)
    {
        quaterNumberStr = "III";
        range = "x < 0; y < 0";
    }
    if (quaterNumberInt == 4)
    {
        quaterNumberStr = "IV";
        range = "x > 0; y < 0";
    }
}
QuaterNumber(quaterNumberInt);
Console.WriteLine($"Четверть номер {quaterNumberStr} имеет следующий диапазон для х и у: {range} ");