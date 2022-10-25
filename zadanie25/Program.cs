Console.WriteLine("введите первое число");
bool isParsedA = int.TryParse(Console.ReadLine(), out int a);
Console.WriteLine("введите второё число");
bool isParsedB = int.TryParse(Console.ReadLine(), out int b);

if (!isParsedA && !isParsedB)
{
    Console.WriteLine("Ошибка! введено не число!!!!");
    return;
}
int result = ExponentiationAB(a, b);
Console.WriteLine(result);

int ExponentiationAB(int numbera, int numberb)
{
     if (numberb < 0)
    {
        numberb = -numberb;
    }
   int exp=1;
    for (int i = 1; i <= numberb; i++)
    {
        exp=exp*numbera;
    }
    return exp;
}