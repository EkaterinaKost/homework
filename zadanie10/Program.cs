Console.WriteLine("введите трёхзначное число");

int numberA = Convert.ToInt32(Console.ReadLine());
int result = ShowSecondNumber(numberA);
Console.WriteLine(result);

int ShowSecondNumber(int number)
{
    number = number / 10;
    number = number % 10;
    return number;
}