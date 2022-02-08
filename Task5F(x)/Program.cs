// Написать программу вычисления значения функции y = f(a)

int F(int arg)
{
    int result = arg * arg;
    return result;
}
    
Console.Write("Введите число ");
string numberAStr = Console.ReadLine();
if(int.TryParse(numberAStr, out int a))
{
    int y = F(a);
    Console.WriteLine($"Значение функции y = f(a) будет {y}");
}
else
{
    Console.WriteLine($"Введено не число");
}