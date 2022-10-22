
Console.WriteLine("введите число, обозначающее день недели");
int number = Convert.ToInt32(Console.ReadLine());

bool result = Weekend(number);

Console.WriteLine(result);
bool Weekend(int numberWeek)
{
    return numberWeek == 6 | numberWeek == 7;
}