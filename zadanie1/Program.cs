Console.WriteLine("введите первое число");

int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите второе число");

int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
  Console.Write("первое число больше" );
}

else
{
    if (numberB > numberA)
    {
         Console.Write("второе число больше");
    }

     else
     {
      Console.Write("числа равны");  
     }
 }
   