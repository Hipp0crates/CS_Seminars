// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

Console.Clear();

Console.Write("Ведите координату точки A по оси X: ");
int xa = Convert.ToInt32(Console.ReadLine());

Console.Write("Ведите координату точки A по оси Y: ");
int ya = Convert.ToInt32(Console.ReadLine());

Console.Write("Ведите координату точки A по оси Z: ");
int za = Convert.ToInt32(Console.ReadLine());

Console.Write("Ведите координату точки B по оси X: ");
int xb = Convert.ToInt32(Console.ReadLine());

Console.Write("Ведите координату точки B по оси Y: ");
int yb = Convert.ToInt32(Console.ReadLine());

Console.Write("Ведите координату точки B по оси Z: ");
int zb = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
// Ограничение до 4-х знаков после запятой
Console.WriteLine($"Расстояние между точками A({xa}; {ya}; {za}) и B({xb}; {yb}; {zb}) = {distance:f4}"); 