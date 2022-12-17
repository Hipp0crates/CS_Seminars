// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();

int[,] GetMatrix(int rowsCount = 5, int columnsCount = 9, int leftRange = 0, int rightRange = 9)
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

int GetPosition(string message)
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

void GetValue(int[,] matr, int numberRow, int numberColumn)
{
    if (numberRow < 1 || numberRow > matr.GetLength(0) || numberColumn < 1 || numberColumn > matr.GetLength(1))
    {
        Console.WriteLine($"Позиции [{numberRow}, {numberColumn}] не существует");
    }
    else
    {
        int result = matr[numberRow - 1, numberColumn - 1];
        Console.WriteLine($"Значение элемента на позиции [{numberRow}, {numberColumn}] = {result}");
    }
}

int row = GetPosition("Введите номер строки: ");
int column = GetPosition("Введите номер столбца: ");
int[,] matrix = GetMatrix();
Console.WriteLine("Задан массив чисел:");
PrintMatrix(matrix);
GetValue(matrix, row, column);