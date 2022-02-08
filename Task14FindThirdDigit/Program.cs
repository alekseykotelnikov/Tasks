// Найти третью цифру числа или сообщить, что её нет

// Автор задачи, пояснил, что, например, третья цифра в числе 546, это 5/

// Сделал два варианта - первый с массивом, отрицательными числами и цифрой слева.

// Второй вариант в репозитории, папка Task14-1FindThirdDigit, там уже ввод пользователя и цифра справа.

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
