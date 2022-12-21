// Задайте двумерный массив. Напишите программу,
// которая упорядочит по возрастанию элементы каждой строки двумерного массива.

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

void SortingRows(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            int min = j;
            for (int n = j + 1; n < matr.GetLength(1); n++)
            {
                if (matr[i, n] < matr[i, min]) min = n;
            }
            int temporary = matr[i, j];
            matr[i, j] = matr[i, min];
            matr[i, min] = temporary;
        }
    }
}

int rows = GetNumber("Введите число строк: ");
int columns = GetNumber("Введите число столбцов: ");
int[,] matrix = GetMatrix(rows, columns);
Console.WriteLine("Задан массив чисел:");
PrintMatrix(matrix);
SortingRows(matrix);
Console.WriteLine("Строки упорядоченны по возрастанию:");
PrintMatrix(matrix);