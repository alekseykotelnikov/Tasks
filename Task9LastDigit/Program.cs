// Показать последнюю цифру трёхзначного числа

int randomNumber = new Random().Next(100, 1000);
Console.WriteLine($"Трехзначное число {randomNumber}");
int lastDigit = randomNumber % 10;
Console.WriteLine($"Последнее число в трехзначном это {lastDigit}");
