// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
//             n + 1, m = 0
// A(m,n) =    A(m - 1, 1) m > 0, n = 0;
//             A(m - 1, A(m, n - 1)) , m > 0, n > 0

Console.Clear();
Console.WriteLine();

int FunctionAkkerman(int m, int n)
{
    if (m == 0)
    {
        return (n + 1);
    }
    if (m > 0 && n == 0)
    {
        return FunctionAkkerman(m - 1, 1);
    }
    return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
}
int m = 3;
int n = 2;
Console.WriteLine($"Даны два неотрицательных числа m = {m} и n = {n}");
Console.Write($"Результат функции Аккермана = ");
Console.WriteLine(FunctionAkkerman(m, n));
