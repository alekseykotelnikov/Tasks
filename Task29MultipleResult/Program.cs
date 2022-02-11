// Написать программу вычисления произведения чисел от 1 до N

int InPut(string message)
{
    Console.WriteLine(message);
    string numStr = Console.ReadLine();
    int numInt = int.Parse(numStr);
    return numInt;
}

int Multiple (int number)
{
    int result = 1;
    for (int i = 1; i <= number; i++)
    {
        result = i * result;
    }
    return result;
}

int numberFirst = InPut("Введите предельное число ");

int multipleResult = Multiple(numberFirst);

Console.WriteLine($"Результат произведения = {multipleResult}");