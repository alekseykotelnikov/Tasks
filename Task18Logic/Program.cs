// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
void Umnojenie (int arg1, int arg2)
{
    for (arg1 = 1; arg1 >= 0; arg1--)
    {
        for (arg2 = 1; arg2 >= 0; arg2--)
        {
            Console.Write(arg1 * arg2);
        }
    }
}

void Sum (int arg1, int arg2)
{
    for (arg1 = 0; arg1 <= 1; arg1++)
    {
        for (arg2 = 0; arg2 <= 1; arg2++)
        {
            int result = arg1 + arg2;
            if (result == 0)
            {
                Console.Write("1");
            }
            else
            {
                Console.Write("0");
            }
        }
    }
}

Console.WriteLine("Значение слева от знака \"=\", будет следующим: ");
Sum (0, 0);
Console.WriteLine();

Console.WriteLine("Значение справа от знака \"=\", будет следующим: ");
Umnojenie (1, 1);
Console.WriteLine();
Console.WriteLine("Утверждение истинно");
