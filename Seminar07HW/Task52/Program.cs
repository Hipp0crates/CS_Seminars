// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 9)
{
    int[,] matr = new int[rowsCount, columnsCount];
    Random rand = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matr;
}

int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void GetArithmeticMeanColumn(int[,] matr)
{
    double result = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            result += matr[i, j];
        }
        Console.WriteLine($"Среднее арифметическое по столбцу {j + 1} = {result / matr.GetLength(0):f2}");
        result = 0;
    }
}

int rows = GetNumber("Введите число строк: ");
int columns = GetNumber("Введите число столбцов: ");
int[,] matrix = GetMatrix(rows, columns);
Console.WriteLine("Задан массив чисел:");
PrintMatrix(matrix);
GetArithmeticMeanColumn(matrix);