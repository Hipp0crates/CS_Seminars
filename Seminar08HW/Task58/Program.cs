// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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
            if (matr[i, j] < 10)
            {
                Console.Write($" {matr[i, j]} ");
            }
            else
            {
                Console.Write($"{matr[i, j]} ");
            }
        }
        Console.WriteLine();
    }
}

int[,] MatrixMultiplication(int rowsCount, int columnsCount, int[,] matr1, int[,] matr2)
{
    int[,] matr = new int[rowsCount, columnsCount];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = matr1[i, j] * matr2[i, j];
        }
    }
    return matr;
}

int rows = GetNumber("Введите число строк: ");
int columns = GetNumber("Введите число столбцов: ");
int[,] matrix1 = GetMatrix(rows, columns);
Console.WriteLine("Матрица 1:");
PrintMatrix(matrix1);
Console.WriteLine("Матрица 2:");
int[,] matrix2 = GetMatrix(rows, columns);
PrintMatrix(matrix2);
Console.WriteLine("Произведение матриц:");
int[,] multi = MatrixMultiplication(rows, columns, matrix1, matrix2);
PrintMatrix(multi);