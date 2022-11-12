// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
int [] numbers=new int[8];
FillArray(numbers);
PrintArray(numbers);
int result=SumOddNumbers(numbers);
Console.WriteLine(result);
int SumOddNumbers(int[]array)
{
    int sum=0;
    for (int i = 0; i <array.Length; i++)
    {
        if(i%2!=0)
        {
            sum=sum+array[i];
        }
    }
    return sum;
}

void FillArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 100);
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