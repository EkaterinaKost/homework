/*Задача 66: Задайте значения M и N. Напишите метод, 
который найдёт сумму натуральных элементов в промежутке от M до N. 
Через рекурсию!

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
Console.WriteLine("введите число m");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("введите число n");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if (!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка! введено не число!!!!");
    return;
}
int result=SumNumbers(m,n);
Console.WriteLine(result);
int SumNumbers(int m,int n,int sum=0)
{
    sum+=m;
    if(m==n)
    {
    return sum=n;
    }
   return sum+=SumNumbers(m+1,n);

}