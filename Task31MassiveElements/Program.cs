// Задать массив из 8 элементов и вывести их на экран

int InPut(string message)
{
    Console.WriteLine(message);
    string numStr = Console.ReadLine();
    int numInt = int.Parse(numStr);
    return numInt;
}

int[] InitArray(int number)
{
    int[] array = new int[number];
    Random numberRan = new Random();
    for (int i = 0; i < number; i++)
    {
        array[i] = numberRan.Next(10, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int number = InPut("Введите число равное количеству элементов в массиве");

int[] array = InitArray(number);

PrintArray(array);