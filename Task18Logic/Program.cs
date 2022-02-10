// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

// ¬ - перевернуть значениеж;
// X ⋁ Y - умножение выражений;
//X ⋀ Y - сложение выражений;

// Вычисляем значения правой части выражения
// Учитывая отрицание (инверсию)

void ConInverseXInverseY()
{
    for (int arg1 = 1; arg1 >= 0; arg1--)
    {
        for (int arg2 = 1; arg2 >= 0; arg2--)
        {
            if (arg1 * arg2 == 1)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}

// Производим операцию слева от знака равно, затем делаем отрицание (инверсию)

void InverseDiz()
{
    for (int arg1 = 0; arg1 <= 1; arg1++)

        for (int arg2 = 0; arg2 <= 1; arg2++)
        {
            int result = arg1 + arg2;
            if (result == 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
}


Console.WriteLine("Значение слева от знака \"=\" (Отрицание дизъюнкции двух выражений), будет следующим: ");
InverseDiz();
Console.WriteLine();

Console.WriteLine("Значение справа от знака \"=\" (Конъюнкция отрицания первого и отрицания второго выражений), будет следующим: ");
ConInverseXInverseY();
Console.WriteLine();

Console.WriteLine("Утверждение истинно");
