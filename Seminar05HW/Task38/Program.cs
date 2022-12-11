// Задайте массив натуральных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

int[] GetRandomArray(int size, int leftRange, int rightRange) // Берем копи-паст генератора массивов
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}

(int, int) GetMaxMin(int[] array) // Ищем минимальное и максимальное
{
    int max = array[0];
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return (max, min);
}

const int SIZE = 10;
const int LEFTRANGE = 1;
const int RIGHTRANGE = 99;

int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine("Генерация массива на 10 элементов натуральными числами от 1 до 99:");
Console.WriteLine("{ " + string.Join(", ", arr) + " }");

(int maxN, int minN) = GetMaxMin(arr);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {maxN} - {minN} = {maxN - minN}");