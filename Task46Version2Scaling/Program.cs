// Написать программу масштабирования фигуры
string valueStr = "(0,0) (2,0) (2,2) (0,2)";
Console.WriteLine("Введите множитель:");
int k = int.Parse(Console.ReadLine());

valueStr = valueStr.Replace("(", "").Replace(")", "").Replace(",", " ");

// Разбиваем строку на массив, разделитель в данном случае, это пробел

string[] arrayStr = valueStr.Split(" ");
string result = string.Empty;
Console.WriteLine();

for (int i = 0; i < arrayStr.Length - 1; i = i + 2)
{
    int x = k * int.Parse(arrayStr[i]);
    int y = k * int.Parse(arrayStr[i + 1]);
    result = result + $"({x}, {y}) ";
}
Console.WriteLine("====================");
Console.WriteLine(result);