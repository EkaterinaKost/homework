/*Задача 60. ...Сформируйте трёхмерный массив 
из неповторяющихся двузначных чисел. 
Напишите метод, который будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2*/

Console.WriteLine("введите длину массива");
bool isParsedX = int.TryParse(Console.ReadLine(), out int x);
Console.WriteLine("введите ширину массива");
bool isParsedY = int.TryParse(Console.ReadLine(), out int y);
Console.WriteLine("введите глубину массива");
bool isParsedZ = int.TryParse(Console.ReadLine(), out int z);
if (!isParsedZ|| !isParsedX || !isParsedY)
{
    Console.WriteLine("Ошибка! введено не число!!!!");
    return;
}

int[,,] array3D = new int[x, y, z];
CreateArray(array3D);
PrintArray(array3D);

void PrintArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
           for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write($"{array3D[i,j,k]}");
        Console.Write($"({i},{j},{k})");
        
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void CreateArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) *array3D.GetLength(1) *array3D.GetLength(2)];
  
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
   
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
         
        }
          
      }
    }
  }
  int count = 0; 
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        array3D[i,j,k] = temp[count];
        count++;
      }
    }
  }
}