﻿// Найти расстояние между точками в пространстве 2D/3D
// Для того, кто не ищет легких путей
// Расстояние d между точками в пространстве A1{x1;y1;z1}, A2{x2;y2;z2} представляется формулой
//это сумма квадратов разницы между большей и меньшей координатой точки на каждой оси
// если ось 2D, то ось Z будет нулевой 

double num = 0;
double Coards(double arg)
{
    num = new Random().Next(1, 100);
    return num;
}

double Long(double first, double second)
{
    double longFirst = (second - first) * (second - first);
    return longFirst;
}
// Получаем значения для координат из рандома

double x1 = Coards(num);
double x2 = Coards(num);
double y1 = Coards(num);
double y2 = Coards(num);
double z1 = Coards(num);
double z2 = Coards(num);

// Сравниваем какая из координат больше, для формулы вычисления расстояния
// присваиваем значения каждой координаты

if (x1 > x2)
{
    double temp = x1;
    x1 = x2;
    x2 = temp;
}

if (y1 > y2)
{
    double temp = y1;
    y1 = y2;
    y2 = temp;
}

if (z1 > z2)
{
    double temp = z1;
    z1 = z2;
    z2 = temp;
}

// Выводим правильное расопложение координат

Console.WriteLine($"Координата x1={x1}, x2={x2}, y1={y1}, y2={y2}, z1={z1}, z2={z2}");

// Вычисляем длинну на каждой из осей

double distanceX = Long(x1, x2);
double distanceY = Long(y1, y2);
double distanceZ = Long(z1, z2);

// высичляем корень из суммы всех длин

double finallDistance = Math.Sqrt(distanceX + distanceY + distanceZ);
Console.WriteLine($"Расстояние между точками = {finallDistance}");