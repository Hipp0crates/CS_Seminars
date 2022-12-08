// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

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

(int, int) GetSumPositiveAndNegative(int[] array)
{
    int sumPositive = 0;
    int sumNegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) // элемент массива положительный
        {
            sumPositive += array[i];
        }
        if (array[i] < 0) // элемент массива отрицательный
        {
            sumNegative += array[i];
        }
    }
    return (sumPositive, sumNegative);
}

const int SIZE = 12;
const int LEFTRANGE = -9;
const int RIGHTRANGE = 9;

int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine("Генерация массива на 12 элнментов случайными числами от -9 до 9:");
Console.WriteLine("{ " + string.Join(", ", arr) + " }");

(int sumP, int sumN) = GetSumPositiveAndNegative(arr);
Console.WriteLine($"Сумма положительных чисел = {sumP}. Сумма отрицательных чисел = {sumN}.");