// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.

Console.Clear();

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}

const int SIZE = 5;
const int LEFTRANGE = 1;
const int RIGHTRANGE = 9;

int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine("{ " + string.Join(", ", arr) + " }");

int[] resarr = new int[arr.Length / 2 + arr.Length % 2];

for (int i = 0; i < arr.Length / 2; i++)
{
    resarr[i] = arr[i] * arr[arr.Length - 1 - i];
}
if (arr.Length % 2 == 1)
{
    resarr[resarr.Length - 1] = arr[arr.Length / 2];
}
Console.WriteLine("{ " + string.Join(", ", resarr) + " }");