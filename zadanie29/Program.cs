Console.WriteLine("введите размер массива");
bool isParsedA = int.TryParse(Console.ReadLine(), out int a);
if (!isParsedA)
{
    Console.WriteLine("Ошибка! введено не число!!!!");
    return;
}
int count=a;
int[] array = new int[count];

for (int i = 0; i < count; i++)
{
    Console.WriteLine($"введите,{i}, элемент массива");
    bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
    if (!isParsedN)
    {
        Console.WriteLine("Ошибка! введено не число!!!!");
    }
    else
    {
        array[i] = n;
    }
}

PrintArray(array);

void PrintArray(int[]print)
{
    Console.Write("[");
    int z=print.Length;
    int position=0;
    while (position<z)
    {
        Console.Write(print[position]);
        Console.Write(" ");
        position++;
    }
    Console.Write("]");
}