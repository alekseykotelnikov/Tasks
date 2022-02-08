// Найти расстояние между точками в пространстве 2D/3D
double num = 0;
double Coards(double arg)
{
    return new Random().Next(1, 10);
}

double Sum (double first, double second)
{
    double sum = (second - first) * (second - first);
    return sum;
}


double x1 = Coards(num);
double x2 = Coards(num);
double y1 = Coards(num);
double y2 = Coards(num);
double z1 = Coards(num);
double z2 = Coards(num);



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



Console.WriteLine($"Координата x1={x1}, x2={x2}, y1={y1}, y2={y2}, z1={z1}, z2={z2}");


double distanceX = Sum(x1, x2);
double distanceY = Sum(y1, y2);
double distanceZ = Sum(z1, z2);

double finallDistance = Math.Sqrt( distanceX + distanceY + distanceZ);
Console.WriteLine($"Расстояние между точками = {finallDistance}");