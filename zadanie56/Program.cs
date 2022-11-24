/*Задача 56: Задайте двумерный массив. Напишите метод, 
который будет находить строку с наименьшей суммой элементов.*/
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

int[] arr=SumOfRowElements(array);
PrintArray(arr);
int res=GetRowWithMinimumAmount(arr);
Console.WriteLine($"{res+1}, -строка");

int[] SumOfRowElements(int[,] array)
{
 int [] result=new int [array.GetLength(0)];
 int sum=0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        sum=sum+array[i,j];
        
        }
        result[i]=sum;
        sum=0;
    }
    return result;
}
int GetRowWithMinimumAmount (int [] array)
{
    int position =0;
    
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i]<array[i-1])
        {
            position=i;
        }
    }
    return position;
}
void PrintArray(int[] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
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
