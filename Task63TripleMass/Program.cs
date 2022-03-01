// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента
// Надо уточнять, что именно имел в виду преподаватель, внося в задание вывод построчно
// Я это понял, как вывод в консоль строк массива 
//(в конкретном случае массив имеет две строки, следовательно вывод в 2 строки)
Console.Clear();
Console.WriteLine();
Random rand = new Random();
int[,,] TripleMass()
{
    int[,,] array = new int[2, 2, 2];
    int n = rand.Next(10, 20);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = n;
                n++;
            }
        }
    }
    return array;
}
void PrintOdd(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"[{i}, {j}, {k}] = {array[i, j, k]}; ");
            }
        }
        Console.WriteLine();
    }
}
int[,,] matrix = TripleMass();
Console.WriteLine("Индексы трехмерного массива построчно:");
PrintOdd(matrix);