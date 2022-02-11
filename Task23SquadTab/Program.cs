// Показать таблицу квадратов чисел от 1 до N

int InPut(string message)
{
    Console.WriteLine(message);
    string numStr = Console.ReadLine();
    int numInt = int.Parse(numStr);
    return numInt;
}

int[] InitArray(int number)
{
    int[] array = new int[number + 1];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = i * i;
    }
    return array;
}

void PrintArray(int[] argarray)
{
    for (int i = 1; i < argarray.Length; i++)
    {
        Console.WriteLine(argarray[i]);
    }
}

int b = InPut("Введите число > 1");
var array = InitArray(b);
PrintArray(array);