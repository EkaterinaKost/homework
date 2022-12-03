/*Задача 64: Задайте значение N. Напишите метод, 
который выведет все натуральные числа в промежутке от N до 1.
 Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
Console.WriteLine("введите число n");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if (!isParsedN)
{
    Console.WriteLine("Ошибка! введено не число!!!!");
    return;
}
PrintNumbers(n);
void PrintNumbers(int n,int i=1)
{
    if (n<i)
    {
        return;
    }
    Console.Write($"{n} ");
    PrintNumbers(n-1,i);
}