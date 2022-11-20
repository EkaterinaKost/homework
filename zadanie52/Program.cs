/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце. 
Поиск среднее арифметического в отдельном методе. 
Для создания массива и вывода можно воспользоваться 
методами из 47 задачи.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
Console.WriteLine("введите количество строк массива");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("введите количество столбцов массива");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
if (!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка! введено не число!!!!");
    return;
}
int[,] array = CreateRandomDouble2DArray(m, n);
Print2DArray(array);
double[] arithmeticMean=FindingArithmeticMeanInColumn(array,n,m);
PrintArray(arithmeticMean);

double[] FindingArithmeticMeanInColumn(int[,]array, int lengh,int height)
{
    double[] result=new double[lengh];
    double sum=0;
    
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum+=array[j,i];
        }
        result[i]=sum/height;
        sum=0;
    }
    return result;
}
void PrintArray(double[] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]:F2} ");
    }
    Console.WriteLine();
}
int[,] CreateRandomDouble2DArray(int m, int n)
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
