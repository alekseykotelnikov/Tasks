// Удалить вторую цифру трёхзначного числа
int randomNumber = new Random().Next(100, 1000);
Console.WriteLine($"Трехзначное число, это {randomNumber}");
int lastDigit = randomNumber % 10;
int firstDigit = randomNumber / 100;
Console.WriteLine($"Трехзначное число без второй цифры, это {firstDigit}{lastDigit}");