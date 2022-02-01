// Kvadrat number;
Console.Write("Введите число "); // Вводим возможность ввода числа
string numberStr = Console.ReadLine(); // Задаем название для считываемой строки (все что вводим в консоль это строки, а не числа)
double number = double.Parse(numberStr); // с помощью функции Parse перевоим строку в число
Console.WriteLine (number * number); // Выводим результат