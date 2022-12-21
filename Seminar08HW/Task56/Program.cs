// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();

int[,] GetMatrix(int rowsCount = 5, int columnsCount = 3, int leftRange = 0, int rightRange = 9)
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

void LowestSumRow(int[,] matr)
{
    int[] array = new int[matr.GetLength(0)];
    int result = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            result += matr[i, j];
            array[i] = result;
        }
        result = 0;
    }
    int min = array[0];
    int row = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            row = i;
        }
    }
    Console.WriteLine($"Минимальная сумма {min} в строке {row + 1}");
}

int[,] matrix = GetMatrix();
Console.WriteLine("Задан массив чисел:");
PrintMatrix(matrix);
LowestSumRow(matrix);