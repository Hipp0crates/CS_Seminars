// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Clear();

double[,] GetMatrix(int rowsCount, int columnsCount, int positiveValue = 10, int negativeValue = 0)
{
    double[,] matr = new double[rowsCount, columnsCount];
    Random rand = new Random();
    if (negativeValue < 0) negativeValue = -negativeValue; // На случай если задано отрицательное значение
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.NextDouble() * (positiveValue + negativeValue) - negativeValue;
        }
    }
    return matr;
}

int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]:f2}  ");
        }
        Console.WriteLine();
    }
}

int rows = GetNumber("Введите число строк: ");
int columns = GetNumber("Введите число столбцов: ");
double[,] matrix = GetMatrix(rows, columns);
PrintMatrix(matrix);