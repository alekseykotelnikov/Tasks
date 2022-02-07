// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

// ¬ - перевернуть значениеж;
// X ⋁ Y - умножение выражений;
//X ⋀ Y - сложение выражений;


void Umnojenie()
{
    for (int arg1 = 1; arg1 >= 0; arg1--)
    {
        for (int arg2 = 1; arg2 >= 0; arg2--)
        {
            Console.Write(arg1 * arg2);
        }
    }
}

void Sum()
{
    for (int arg1 = 0; arg1 <= 1; arg1++)

        for (int arg2 = 0; arg2 <= 1; arg2++)
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


Console.WriteLine("Значение слева от знака \"=\", будет следующим: ");
Sum();
Console.WriteLine();

Console.WriteLine("Значение справа от знака \"=\", будет следующим: ");
Umnojenie();
Console.WriteLine();

Console.WriteLine("Утверждение истинно");
