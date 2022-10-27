Console.WriteLine("введите число");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
if (!isParsedN)
{
    Console.WriteLine("Ошибка! введено не число!!!!");
    return;
}

int result=SumAllNumbers(n);
Console.WriteLine(result);

int LenghtNumber(int a)
{
    int count = 0;
    while (a > 0)
    {
        a /= 10;
        count++;
    }
    return count;
}

int SumAllNumbers(int number)
{
    int count = LenghtNumber(number);

    int sum = 0;

    for (int i = 0; i < count; i++)
    {
        int b = number % 10;
        number /= 10;
        sum = sum + b;
    }
    return sum;
}

