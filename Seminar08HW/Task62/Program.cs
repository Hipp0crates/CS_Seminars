// Заполните спирально массив 4 на 4.

Console.Clear();
// Добавим сложности: рандомный размер
int[,] GetMatrix(int rowsCount, int columnsCount)
{
    int[,] matr = new int[rowsCount, columnsCount];
    int minI = 0;
    int minJ = 0;
    int maxI = matr.GetLength(0) - 1;
    int maxJ = matr.GetLength(1) - 1;
    int number = 1;
    while (number <= matr.GetLength(0) * matr.GetLength(1))
    {
        for (int j = minJ; j <= maxJ; j++)
        {
            int i = minI;
            matr[i, j] = number;
            number++;
        }
        if (minI == maxI)
        {
            break;
        }
        else
        {
            minI++;
        }
        for (int i = minI; i <= maxI; i++)
        {
            int j = maxJ;
            matr[i, j] = number;
            number++;
        }
        if (minJ == maxJ)
        {
            break;
        }
        else
        {
            maxJ--;
        }
        for (int j = maxJ; j >= minJ; j--)
        {
            int i = maxI;
            matr[i, j] = number;
            number++;
        }
        maxI--;
        for (int i = maxI; i >= minI; i--)
        {
            int j = minJ;
            matr[i, j] = number;
            number++;
        }
        minJ++;
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
                Console.Write($"  {matr[i, j]} ");
            }
            else if (matr[i, j] < 100 && matr[i, j] > 9)
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

Console.WriteLine("Чтобы терминал вменямо отобразил массив вводите числа не более 31.");
int rows = GetNumber("Введите число строк: ");
int columns = GetNumber("Введите число столбцов: ");
int[,] matrix = GetMatrix(rows, columns);
Console.WriteLine("Заполняем матрицу по сходящейся спирали:");
PrintMatrix(matrix);