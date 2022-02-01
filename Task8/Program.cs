// Все целые числа диапозона
int count = 0;
int lastNumber = 1;
while(count < lastNumber)
{
    if(lastNumber % 2 == 0)
    {
        Console.WriteLine(lastNumber);
    }
    count++;
    lastNumber++;
}
