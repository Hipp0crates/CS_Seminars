// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

Console.Clear();

int[] GetRandomArray(int size, int leftRange = -1000, int rightRange = 1000)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}

const int SIZE = 123;
const int LEFTRANGE = 0; // если не задали будут те, ччто  указали по умолчанию
const int RIGHTRANGE = 150;

int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine("{ " + string.Join(", ", arr) + " }");

int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] >= 10 && arr[i] <= 99)
    {
        count++;
    }
}
Console.WriteLine(count);