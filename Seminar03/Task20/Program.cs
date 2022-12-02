// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.

Console.Clear();

Console.WriteLine("Ведите координату точки A по X: ");
int xa = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите координату точки A по Y: ");
int ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите координату точки B по X: ");
int xb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите координату точки B по Y: ");
int yb = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));
Console.WriteLine("Расстояние между точками: " + $"{distance:f3}");