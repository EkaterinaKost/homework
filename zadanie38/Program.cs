// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
double[] numbers = new double[8];

FillArray(numbers);
PrintArray(numbers);
double maximum = MaxNumber(numbers);
double minimum = MinNumber(numbers);
Console.WriteLine(maximum - minimum);

double MaxNumber(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double MinNumber(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

void FillArray(double[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-10, 10);
    }
}
void PrintArray(double[] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");//почему-то выводит целые числа?
    }
    Console.WriteLine();
}