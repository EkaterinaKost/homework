/*Задача 68: Напишите метод вычисления функции 
Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

Console.WriteLine("введите не отрицательное число натуральное число m");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("введите не отрицательное число n");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if (!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка! введено не число!!!!");
    return;
}
Console.WriteLine(ColculatingTheAckermanFunction(m, n));
int ColculatingTheAckermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if ((m != 0) && (n == 0))
        {
            return ColculatingTheAckermanFunction(m - 1, 1);
        }
        else
        {
            return ColculatingTheAckermanFunction(m - 1, ColculatingTheAckermanFunction(m, n - 1));

        }

    }
}
