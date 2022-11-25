/*Задача 58: Задайте две матрицы. 
Напишите метод, который будет находить произведение двух матриц.*/
Console.WriteLine("введите количество строк первой матрицы");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("введите количество столбцов первой матрицы");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
Console.WriteLine("введите количество строк второй матрица");
bool isParsedX = int.TryParse(Console.ReadLine(), out int x);
Console.WriteLine("введите количество столбцов второй матрицы");
bool isParsedY = int.TryParse(Console.ReadLine(), out int y);
if (!isParsedM || !isParsedN || !isParsedX || !isParsedY)
{
    Console.WriteLine("Ошибка! введено не число!!!!");
    return;
}

int[,] firstMult = CreateRandom2DArray(m, n);
int[,] secondtMult = CreateRandom2DArray(x, y);
Print2DArray(firstMult);
Console.WriteLine();
Print2DArray(secondtMult);
Console.WriteLine();
if (m!=y) 
{
    Console.WriteLine("матрицы невозможно перемножить");
    return;
}

int[,] secondChang = ChangeColumsAndRows(secondtMult);
int[,] mult=FindingMultiplicationOfTwoMatrices(firstMult,secondChang);
Print2DArray(mult);
int[,] ChangeColumsAndRows(int[,] array)
{
    int[,] array2 = new int[array.GetLength(1), array.GetLength(0)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            array2[i, j] = array[j, i];
        }
    }
    return array2;
}

int[,] FindingMultiplicationOfTwoMatrices(int[,] array, int[,] array2)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    int sum = 0;
    //int index=0;
    for (int k = 0; k <array.GetLength(0); k++)
    {
        for (int i = 0; i < array2.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum = sum + array[k, j] * array2[i, j];
            }
            result[k, i] = sum;
            //index++;
            sum=0;
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