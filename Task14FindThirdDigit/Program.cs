// Найти третью цифру числа или сообщить, что её нет

int[] array = { 25, 159, 1, 0, -258, -100, 345, -876 };
int n = array.Length;
int index = 0;

while (index < n)
{
    if (array[index] < 100 && array[index] > -100)
    {
        Console.WriteLine("Третьей цифры в числе нет");
    }
    else
    {
        int findThirdDigit = array[index] / 100;

        if (findThirdDigit < 0)
        {
            findThirdDigit = findThirdDigit * -1;
        }
        Console.WriteLine($"Третья цифра в числе {findThirdDigit}");
    }
    index++;
}
