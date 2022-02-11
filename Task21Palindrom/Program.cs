// Программа проверяет пятизначное число на палиндромом.

int InPut(string message)
{
    Console.WriteLine(message);
    string numStr = Console.ReadLine();
    int numInt = int.Parse(numStr);
    return numInt;
}

int palindrom = InPut("Введите пятизначное число ");

bool digitOne = palindrom % 10 == palindrom / 10000;

bool digitTwo = (palindrom / 10) % 10 == (palindrom / 1000) % 10;

if (digitOne && digitTwo)
{
    Console.WriteLine("Число является палиндромом ");
}
else
{
    Console.WriteLine("Число не является палиндромом ");
}