// Показать кубы чисел, заканчивающихся на четную цифру

void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(-11, 13);
    }
}

void PrintArray(int[] col)
{
    for (int j = 0; j < col.Length; j++)
    {
        Console.Write($"{col[j]} ");
    }
    Console.WriteLine();
}

void PrintEvenNumbers(int[] collect)
{
    for (int count = 0; count < collect.Length; count++)
    {
        int n = collect[count];// Вводим переменную для красивого тображения результата
        collect[count] = collect[count] * collect[count] * collect[count];
        if (collect[count] % 2 == 0)
        {
            if (collect[count] % 10 == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine($"Число {n} в кубе = {collect[count]}");
            }
        }
        else
        {
            Console.Write("");
        }
    }
}

int[] array = new int[10];
FillArray(array);
Console.WriteLine("Задан следующий массив чисел:");
PrintArray(array);
Console.WriteLine("Кубы чисел, из заданного массива, заканчивающихся на четную цифру, это ");
PrintEvenNumbers(array);
