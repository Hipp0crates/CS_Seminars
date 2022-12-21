// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.Clear();

void Get3DArray(int sizeX = 2, int sizeY = 2, int sizeZ = 2, int from = 10)
{
    int[,,] matr = new int[sizeX, sizeY, sizeZ];
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                matr[i, j, k] = from;
                from += rand.Next(1, 4);
                Console.WriteLine($"{matr[i, j, k]} ({i},{j},{k})");
            }
        }
    }
}

Get3DArray();