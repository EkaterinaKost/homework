/*Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/
Console.WriteLine("введите количество вводимых чисел");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
if (!isParsedM)
{
    Console.WriteLine("Ошибка! введено не число!!!!");
    return;
}
int[]arr=new int [m];
arr=EnteringNumbers(m);
PrintArray(arr);
int result= GetTheNumberOfPositiveNumbers(arr);
Console.WriteLine($"количество положительных чисел = {result}");

int[] EnteringNumbers(int number)
{
    int[] array=new int[number];
    for (int i = 0; i < number; i++)
    {
        Console.WriteLine("введите число");
        array[i]=Convert.ToInt32(Console.ReadLine());
    }
    return array;
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

int GetTheNumberOfPositiveNumbers (int[] array)
{
    int count=0;
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i]>0) 
       {
        count++;
       }
    }
    return count;
}




