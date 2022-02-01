// Все целые числа диапозона
int count = 0;
int number = 1;
while(count < 20)
{
    if(number % 2 == 0)
    {
        Console.WriteLine(number);
    }
    count++;
    number++;
}
