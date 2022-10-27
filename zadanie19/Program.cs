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
//if (result == 2)
//{
  //  Console.WriteLine("Ошибка! Число не пятизначное");
//}
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
int Palindrom(int number)
{
    int count = LenghtNumber(number);

    //if (count == 5)
    //  {
    int[] array = new int[count];

    for (int y = 0; y < count; y++)
    {
        array[y] = number % 10;
        number /= 10;
    }
    int i = 0;
    int fix = count / 2;
    while (i < fix)
    {
        if (array[i] == array[count-1])
        {
            i++;
            count = count - 1;
        }
        else
        {
            return 0;
        }
    }
    return 1;
    //else
    //{
      //  return 2;
   // }
}