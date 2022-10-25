// See https://aka.ms/new-console-template for more information
Console.WriteLine("введите пятизначное число");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
if (!isParsedN)
{
    Console.WriteLine("Ошибка! введено не число!!!!");
    return;
}

int result = Palindrom(n);

if (result == 1)
{
    Console.WriteLine($"{n} - палиндром");
}
if (result == 0)
{
    Console.WriteLine($"{n} - не является палиндромом");
}
if (result==2)
{
    Console.WriteLine("Ошибка! Число не пятизначное");
}
int Palindrom(int number)
{
    int count = 0;
    while (number > 0)
    {
        number /= 10;
        count++;
    }
    if (count == 5)
    {
        int[] array = new int[5];

        for (int i = 0; i < 5; i++)
        {
            array[i] = number % 10;
            number /= 10;
        }
        if (array[0] == array[4] && array[1] == array[3])
        {
            return 1;//почему то при ветвлении всегда возвращает 1...Почему?
        }
        else
        {
            return 0;
        }
    }
    else
    {
        return 2;
    }
}