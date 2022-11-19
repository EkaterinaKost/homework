/*Задача 50. Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 , 7 -> такого числа в массиве нет
1 , 1 -> 1*/
Console.WriteLine("введите количество строк массива");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("введите количество столбцов массива");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
if (!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка! введено не число!!!!");
    return;
}
int[,] array = CreateRandom2DArray(m, n);
Print2DArray(array);
Console.WriteLine("введите номер строки искомого элемента");
bool isParsedA = int.TryParse(Console.ReadLine(), out int a);
Console.WriteLine("введите номер столбца искомого элемента");
bool isParsedB = int.TryParse(Console.ReadLine(), out int b);
if (!isParsedA || !isParsedB)
{
    Console.WriteLine("Ошибка! введено не число!!!!");
    return;
}
string element=SearchingForArrayElement(array, a,b);
Console.Write("искомый элемент = ");
Console.WriteLine(element);
string SearchingForArrayElement(int[,] array, int x, int y)
{
    string result="";
    int str=array.GetLength(0);
    int col=array.GetLength(1);
    if (x > str || y > col)
    {
        result="такого элемента нет";
        return result;
    }
   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == x && j == y)
            {
                int found=array[i, j];
                 result = found.ToString();
            }
        }

    }
    return result;

}
int[,] CreateRandom2DArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(-10, 10);
        }

    }
    return array;
}
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
