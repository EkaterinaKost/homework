Console.WriteLine("введите трёхзначное число");

int numberA = Convert.ToInt32(Console.ReadLine());
int result=ShowSecondNumber(numberA);
Console.WriteLine(result);

int ShowSecondNumber(int number)
{
    if (number / 100 == 0 | number/1000!=0)
    {

        Console.WriteLine("ошибка");
    return -1;
        }
    else
    {
    number=number/10;
    number=number%10;

    return number;
    } 
     
}