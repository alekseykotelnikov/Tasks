// Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Clear();
Console.WriteLine();
int SumRec(int m, int n)
{
    int sum = m;
    if (m < n)
    {
        sum += SumRec(m + 1, n);
    }
    return sum;
}
int m = 1;
int n = 5;
int result = SumRec(m, n);
Console.WriteLine($"Сумма натуральных чисел от {m} до {n}, это: {result}");