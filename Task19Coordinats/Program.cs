// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

int coordX = 0;
string quater = string.Empty;
while (coordX == 0)
{
    Console.Write("Введите значение координаты X, не равной 0 ");
    string numberStr = Console.ReadLine();
    int.TryParse(numberStr, out coordX);
}
int coordY = 0;
while (coordY == 0)
{
    Console.Write("Введите значение координаты Y, не равной 0 ");
    string numberStr = Console.ReadLine();
    int.TryParse(numberStr, out coordY);
}

if (coordX > 0 && coordY > 0)
{
    quater = "I";
    Console.Write($"Четверть плоскости точки с координатами x = {coordX}; y= {coordY} будет {quater} ");
}
if (coordX < 0 && coordY > 0)
{
    quater = "II";
    Console.Write($"Четверть плоскости точки с координатами x = {coordX}; y= {coordY} будет {quater} ");
}
if (coordX < 0 && coordY < 0)
{
    quater = "III";
    Console.Write($"Четверть плоскости точки с координатами x = {coordX}; y= {coordY} будет {quater} ");
}
if (coordX > 0 && coordY < 0)
{
    quater = "IV";
    Console.Write($"Четверть плоскости точки с координатами x = {coordX}; y= {coordY} будет {quater} ");
}