// Найти максимальное из трех чисел
Console.Write("Введите первое число ");
string numberAStr = Console.ReadLine();
double numberA = double.Parse(numberAStr);
Console.Write("Введите второе число ");
string numberBStr = Console.ReadLine();
double numberB = double.Parse(numberBStr);
Console.Write("Введите третье число ");
string numberCStr = Console.ReadLine();
double numberC = double.Parse(numberCStr);
double max = numberA;
if(numberB > numberA) max = numberB;
if(numberC > numberB) max = numberC;
Console.Write("Большее число это ");
Console.WriteLine(max);