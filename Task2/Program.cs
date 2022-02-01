// Даны два числа, вычислите большее и меньшее число
Console.Write("Введите первое число ");
string numberAStr = Console.ReadLine();
double numberA = double.Parse(numberAStr);
Console.Write("Введите второе число ");
string numberBStr = Console.ReadLine();
double numberB = double.Parse(numberBStr);
if(numberB == numberA)
{
    Console.WriteLine("Числа одинаковые");
}
else
{
    if(numberA - numberB < 0)
    {
    Console.Write("Большее второе число ");
    Console.WriteLine(numberB);
    Console.Write("Меньшее первое число ");
    Console.WriteLine(numberA);
    }
    else
    {
    Console.Write("Большее второе число ");
    Console.WriteLine(numberA);
    Console.Write("Меньшее первое число ");
    Console.WriteLine(numberB);
    }
}