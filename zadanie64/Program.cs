/*Задача 62. Напишите метод, который заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/
Console.WriteLine("введите количество строк и столбцов квадратного массива");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
if (!isParsedN)
{
    Console.WriteLine("Ошибка! введено не число!!!!");
    return;
}
int[,] array = Create2DArray( n);
Print2DArray(array);
Console.WriteLine();


int[,] Create2DArray( int n)
{
    int[,] array = new int[n, n];
    int a=0;
    int b=n-1;
    int count=0;
   for (int k=1;k<=n/2; k++)
   {   
   for (int i = a; i <=b; i++)
    {
        array[a,i]=count+1;  
        count++;      
    }
    
    for (int j = a; j < b; j++)
        {
            array[j,b] = count;
            count++;
        }

    for (int i = b; i>a; i--)
    {
        array[b,i]=count;
        count++;
    }
    for (int i = b; i > a; i--)
    {
        array[i,a]=count;
        count++;
    }
    count--;
    a++;
    b--;
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