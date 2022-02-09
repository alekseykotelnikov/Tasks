// Найти кубы чисел от 1 до N

int numberN = 0;
while (numberN == 0)
{
    Console.Write("Введите предельное число от 1 ");
    string numberStr = Console.ReadLine();
    int.TryParse(numberStr, out numberN);
}

int[] GetCubeTab(int number)
{
    int[] array = new int[numberN + 1];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = i * i * i;
    }
    return array;
}

void PrintArray(int[] argarray)
{
    for (int i = 1; i < argarray.Length; i++)
    {
        Console.Write($"{i} в кубе = ");
        Console.WriteLine(argarray[i]);
    }
}

int[] array = GetCubeTab(numberN);
PrintArray(array);