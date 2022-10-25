Console.WriteLine("введите число N");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
if (!isParsedN)
{
    Console.WriteLine("Ошибка! введено не число!!!!");
    return;
}
int[]GetTableCube (int n)
{
    int[]array = new int[n];
    for (int i=0; i<array.Length; i++)
    {
        array[i]=(i+1)*(i+1)*(i+1);
    }
    return  array;
}
int[]result=GetTableCube(n);
PrintArray(result);
void PrintArray(int []array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}