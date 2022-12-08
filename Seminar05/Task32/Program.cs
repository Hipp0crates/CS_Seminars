// Напишите программу замены элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.

Console.Clear();

int[] GetRandomArray(int size, int leftRange, int rightRange) // генератор
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}
const int SIZE = 12;
const int LEFTRANGE = -9;
const int RIGHTRANGE = 9;

int[] array = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
// int[] array = { -4, -8, 8, 2, 9, -7, -5, 1 };
Console.WriteLine("Генерация массива на 12 элнментов случайными числами от -9 до 9:");
Console.WriteLine("{ " + string.Join(", ", array) + " }");

int i = 0;
while (i < array.Length)
{
    array[i] *= -1;
    i++;
}
Console.WriteLine("Массив c замененными элементами:");
Console.WriteLine("{ " + string.Join(", ", array) + " }");