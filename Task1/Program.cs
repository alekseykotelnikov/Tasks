// Является ли первое квадратом второго
Console.Write("Введите первое число ");
string numberAStr = Console.ReadLine();
double numberA = double.Parse(numberAStr);
Console.Write("Введите второе число ");
string numberBStr = Console.ReadLine();
double numberB = double.Parse(numberBStr);
if(numberA / numberB == numberB)

    Console.WriteLine("True ");

else

    Console.WriteLine("False ");
