// Показать вторую цифру трёхзначного числа
int randomNumber = new Random().Next(100, 1000);
Console.WriteLine($"Трехзначное число {randomNumber}");
int lastDigit = randomNumber / 10;
int secondDigit = lastDigit % 10;
Console.WriteLine($"Вторая цифра в трехзначном числе, это {secondDigit}");