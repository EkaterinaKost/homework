/*Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами. 
Сделать отдельный метод который генерирует двумерный массив
 и отдельный метод который выводит его на экран.
m и n вводит пользователь в консоль
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/
Console.WriteLine("введите количество строк массива");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("введите количество столбцов массива");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
if (!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка! введено не число!!!!");
    return;
}
double[,] array=CreateRandom2DArray(m,n);
PrintArray(array);

double[,] CreateRandom2DArray(int m,int n)
{
    double[,] array = new double[m, n];
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.NextDouble();//?!!выдает маленькие числа
            //с большим количеством цифр после нуля...
        }

    }
return array;
}
void PrintArray(double[,] array)
{
 for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
