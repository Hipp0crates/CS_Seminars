// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2.
// Значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();

double[,] values = new double[2, 2]; // Ввод данных в двумерный массив
for (int i = 0; i < values.GetLength(0); i++)
{
    Console.WriteLine($"Введите коэффициенты {i + 1} уравнения (y = k{i + 1} * x + b{i + 1})");
    for (int j = 0; j < values.GetLength(1); j++)
    {
        if (j == 0)
        {
            Console.Write($"Введите коэффициент k{i + 1}: ");
        }
        else
        {
            Console.Write($"Введите коэффициент b{i + 1}: ");
        }
        values[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

if (values[0, 0] == values[1, 0] && values[0, 1] == values[1, 1])
{
    Console.WriteLine("Прямые одинаковые");
}
else if (values[0, 0] == values[1, 0] && values[0, 1] != values[1, 1])
{
    Console.WriteLine($"Прямые параллельны");
}
else
{
    double pointX = (values[1, 1] - values[0, 1]) / (values[0, 0] - values[1, 0]);
    double pointY = pointX * values[0, 0] + values[0, 1];
    Console.WriteLine($"Точка пересечения прямых: ({pointX:f4}, {pointY:f4})"); // Округлил
}