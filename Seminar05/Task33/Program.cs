// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.

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

bool isNumberInArray(int[] array, int findNumber) // true - элемент найден, false - не найден
{
    bool res = false; // изначально полагаем, что элемента в массиве нет
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == findNumber)
        {
            res = true;
            break;
        }
    }
    return res;
}

Console.Write("Введите искомое число от -9 до 9: ");
int number = Convert.ToInt32(Console.ReadLine()); // что ищем

const int SIZE = 12;
const int LEFTRANGE = -9;
const int RIGHTRANGE = 9;

int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine("Генерация массива на 12 элнментов случайными числами от -9 до 9:");
Console.WriteLine("{ " + string.Join(", ", arr) + " }");

bool result = isNumberInArray(arr, number);
if (result == true)
{
    Console.WriteLine($"ДА, число {number} есть в массиве");
}
else
{
    Console.WriteLine($"Нет числа {number} в массиве");
}