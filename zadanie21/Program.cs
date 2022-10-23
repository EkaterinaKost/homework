Console.WriteLine("введите координаты точек");
bool isParsedXA = int.TryParse(Console.ReadLine(), out int xaa);
bool isParsedYA = int.TryParse(Console.ReadLine(), out int yaa);
bool isParsedZA = int.TryParse(Console.ReadLine(), out int zaa);
bool isParsedXB = int.TryParse(Console.ReadLine(), out int xbb);
bool isParsedYB = int.TryParse(Console.ReadLine(), out int ybb);
bool isParsedZB = int.TryParse(Console.ReadLine(), out int zbb);
if(!isParsedXA|| !isParsedYA || !isParsedXB|| 
   !isParsedYB ||!isParsedZA || !isParsedZB)
{
    Console.WriteLine("Ошибка! Не правильно введены координаты!!!!");
    return;
}

double distAB = DistanceAB (xaa,yaa,zaa, xbb, ybb,zbb);
Console.WriteLine (distAB);
double DistanceAB(int xa, int ya,int za, int xb, int yb, int zb)
{
    double dist = Math.Sqrt((xb-xa)*(xb-xa)+(yb-ya)*(yb-ya)+(zb-za)*(zb-za));
    return dist;
}
