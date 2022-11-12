//Задайте массив заполненный случайными положительными трёхзначными 
//числами. Напишите программу, которая покажет количество
// чётных чисел в массиве.
int[] numbers = new int[8];

FillArray(numbers);
PrintArray(numbers);
int result = GetEvenNumbers(numbers);
Console.WriteLine(result);

int GetEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}


void FillArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
    }
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
