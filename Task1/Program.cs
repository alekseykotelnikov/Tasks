// Является ли первое квадратом второго


int numberA = 0;
int numberB = 0;

while (numberA == 0)
{
    Console.Write("Введите первое число ");
    string? numberAStr = Console.ReadLine();
    int.TryParse(numberAStr, out numberA);
}

while (numberB == 0)
{
    Console.Write("Введите второе число ");
    string? numberBStr = Console.ReadLine();
    int.TryParse(numberBStr, out numberB);
}



if (numberA / numberB == numberB)

    Console.WriteLine("True ");

else

    Console.WriteLine("False ");
