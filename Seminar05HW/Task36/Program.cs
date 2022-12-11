// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

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

int GetSumOddPositions(int[] array) // Рисуем сумматор чисел на нечётных позициях
{
    int sumodd = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sumodd += array[i];
    }
    return (sumodd);
}

// Ограничимся для примера массивом на 10 элементов от -9 до 9
const int SIZE = 10;
const int LEFTRANGE = -9;
const int RIGHTRANGE = 9;

int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine("Генерация массива на 10 элементов случайными числами от -9 до 9:");
Console.WriteLine("{ " + string.Join(", ", arr) + " }");

int sumOdd = GetSumOddPositions(arr);
Console.WriteLine($"Сумма элементов на нечетных позициях = {sumOdd}");