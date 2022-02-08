// Задать номер четверти, показать диапазоны для возможных координат

int quaterNumber = new Random() .Next(1, 5);
string range = " ";
if (quaterNumber == 1)
{
    range = "x > 0; y > 0";
}
if (quaterNumber == 2)
{
    range = "x < 0; y > 0";
}
if (quaterNumber == 3)
{
    range = "x < 0; y < 0";
}
if (quaterNumber == 4)
{
    range = "x > 0; y < 0";
}

Console.WriteLine($"Четверть номер {quaterNumber} имеет следующий диапазон для х и у: {range} ");