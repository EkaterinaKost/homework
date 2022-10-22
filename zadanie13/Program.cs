Console.WriteLine("введите число");

int numberA = Convert.ToInt32(Console.ReadLine());
int fg= ThreeNumber(numberA);

Console.WriteLine(fg);

int ThreeNumber(int number)
{
    if (number / 100 == 0)
    {
        Console.WriteLine("третьей цифры нет");

    }
    int[] array = new int[1000000];//заводим новый массив
    int i = 0;
    int count = 0;
    int n = array.Length;//длинна массива
    while (i < n - 1)
    {
        int lastvalue = number % 10;
        array[i] = lastvalue;
        number = number / 10;
        if (lastvalue != 0 & number != 0)//если остаток и число одновременно не равны 0
        {
            count++;//счётчик считает кол-во цифр в заданном числе
        }
        i++;

    }
    count = count - 2;//третий элемент
    number = array[count];
    return number;
}// но почему-то иногда выдает не верное число...не могу пока догадаться