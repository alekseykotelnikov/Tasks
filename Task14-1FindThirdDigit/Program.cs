// Найти третью цифру числа или сообщить, что её нет? Вариант уровня GODMODE 

Console.Write("Введите число ");
string valueStr = Console.ReadLine();
if (int.TryParse(valueStr, out int valueInt))
{
    if (valueStr.Length >= 3)
    {
        Console.WriteLine($"Третья цифра числа {valueStr[2]}");
    }
    else
    {
        Console.WriteLine("Число не трехзначное");
    }
}
else
{
    Console.WriteLine("Ввели не число");

}