Console.WriteLine("введите число больше 0");

int numberA = Convert.ToInt32(Console.ReadLine());

int i = 1;

if (numberA >= 2)
{
    while (i <= numberA)
    {
        if (i%2 == 0)
        {
            Console.Write(i);
            Console.Write(";");
        }
        
        i+=1;
        
    } 
}
else
{
    Console.WriteLine("введите число побольше");
}
