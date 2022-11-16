// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


// Функция для подсчета расстояния между точками в 3D пространстве.
double DistanceBetweenPoints(int x1, int y1, int z1, int x2, int y2, int z2 )
{   
    double distance = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
    return distance;
}

Console.WriteLine("Введи Х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введи Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введи Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введи Х2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введи Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введи Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance = DistanceBetweenPoints(x1, y1, z1, x2, y2, z2);
System.Console.WriteLine(distance);
