// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

/* 1-Monday; 2-Tuesday;
3-Wednesday; 4-Thursday;
5-Friday; 6-Saturday;7-Sunday;
Weekend - Saturday and Sunday;*/

int randomNumber = new Random().Next(1, 8);

bool Weekend(int number)
{
    return randomNumber > 5;
}

if (Weekend(randomNumber))
{
    Console.WriteLine($"Номер дня недели {randomNumber} является выходным");
}
else
{
    Console.WriteLine($"Номер дня недели {randomNumber} является не выходным");
}