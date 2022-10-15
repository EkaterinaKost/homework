Console.WriteLine("введите число");

int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA%2 == 0)
{
    Console.Write(numberA);
    Console.Write(" - чётное число");
}
else
{
    Console.Write(numberA);
    Console.Write(" - не чётное число");
}
