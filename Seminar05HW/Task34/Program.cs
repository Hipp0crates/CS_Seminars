// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

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

int GetAmountEvenNumbers(int[] array) // Рисуем счётчик чётных чисел
{
    int even = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            even++;
        }
    }
    return (even);
}

const int SIZE = 15;
const int LEFTRANGE = 100;
const int RIGHTRANGE = 999;

int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine("Генерация массива на 15 элементов случайными числами от 100 до 999:");
Console.WriteLine("{ " + string.Join(", ", arr) + " }");

int sumEven = GetAmountEvenNumbers(arr);
Console.WriteLine($"Количество чётных чисел в массиве = {sumEven}");