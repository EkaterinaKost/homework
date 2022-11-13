/*Задача 43: Напишите программу, которая найдёт точку пересечения
 двух прямых, заданных уравнениями 
 y = k1 * x + b1, y = k2 * x + b2; 
 значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
Console.WriteLine("введите значение k1");
bool isParsedK1 = int.TryParse(Console.ReadLine(), out int kone);
if (!isParsedK1)
{
    Console.WriteLine("Ошибка! введено не число!!!!");
    return;
}
Console.WriteLine("введите значение b1");
bool isParsedB1 = int.TryParse(Console.ReadLine(), out int bone);
if (!isParsedB1)
{
    Console.WriteLine("Ошибка! введено не число!!!!");
    return;
}
Console.WriteLine("введите значение k2");
bool isParsedK2 = int.TryParse(Console.ReadLine(), out int ktwo);
if (!isParsedK2)
{
    Console.WriteLine("Ошибка! введено не число!!!!");
    return;
}
Console.WriteLine("введите значение b2");
bool isParsedB2 = int.TryParse(Console.ReadLine(), out int btwo);
if (!isParsedB2)
{
    Console.WriteLine("Ошибка! введено не число!!!!");
    return;
}
double[] result=new double[2];
result=FindTheIntersectionPointOfStraightLines(kone,bone,ktwo,btwo);
Console.WriteLine($"координаты точки пересечения прямых y = k1 * x + b1, y = k2 * x + b2 ({result[0]},{result[1]})");
double[] FindTheIntersectionPointOfStraightLines (double ko, double bo, double kt, double bt)
{
    double x=(bt-bo)/(ko-kt);
    double y=(bt*ko-bo*kt)/(ko-kt);
    double[] array=new double[2];
    array[0]=x;
    array[1]=y;
    return array;
}