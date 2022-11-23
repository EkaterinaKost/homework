/*Задача 54: Задайте двумерный массив. Напишите метод, 
который упорядочит по убыванию элементы каждой 
строки двумерного массива. И продемонстрируйте его работу.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/
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
Console.WriteLine();
SelectionInDescendingOrderInRows(array);
Print2DArray(array);

void SelectionInDescendingOrderInRows(int[,] array)
{

    int minPosition = 0;
    int temporary = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1) - 1; j++)

        {

            minPosition = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, minPosition]) minPosition = k;
            }
            temporary = array[i, j];
            array[i, j] = array[i, minPosition];
            array[i, minPosition] = temporary;

        }
    }
}
int[,] CreateRandom2DArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(0, 10);
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
