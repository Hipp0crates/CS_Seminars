// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

Console.Clear();

int[] massive = {5, 4, 2, 1, 53, 234};
int[] mass = new int[massive.Length];

for (int i = 0; i < massive.Length; i++)
{
    mass[i] = massive[i];
}
Console.WriteLine(string.Join(", ", massive));
Console.WriteLine(string.Join("; ", mass));