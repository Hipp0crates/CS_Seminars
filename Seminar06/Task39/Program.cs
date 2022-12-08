// Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

Console.Clear();

int[] GetRandomArray(int size ,int leftRange = -10, int rightRange = 150)
{
    int[] array = new int[size];
    Random rand = new Random();

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }

    return array;
}

void Reverse(int[] array)
{
    for(int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
}

const int SIZE = 6;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 150;

int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine(string.Join(", ", arr));

Reverse(arr);
Console.WriteLine();
Console.WriteLine(string.Join(", ", arr));