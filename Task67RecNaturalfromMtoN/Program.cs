// Задайте значения M и N. Напишите программу, которая выведет все 
//натуральные числа в промежутке от M до N.
Console.Clear();
Console.WriteLine();

string NumberRec(int m, int n)
{
    if (m <= n)
    {
        return $"{m} " + NumberRec(m + 1, n);
    }
    else
    {
        return string.Empty;
    }
}
int m = 1;
int n = 10;
Console.WriteLine($"Задано число М = {m}, и число N = {n}");
Console.WriteLine("Натуральные числа в промежутке от M до N, это:");
Console.WriteLine(NumberRec(m, n));