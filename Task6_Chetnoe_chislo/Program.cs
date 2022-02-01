// Выяснить является ли число чётным
Console.Write("Введите число ");
string numberAStr = Console.ReadLine();
double numberA = double.Parse(numberAStr);
if(numberA % 2 == 0)
{
    Console.WriteLine("Данное число является четным");
}
else
{
    Console.WriteLine("Данное число является нечетным");
}