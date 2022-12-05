// Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран. Данные вводятся с консоли пользователем.

Console.Clear();

int length = 8;
int[] array = new int[length]; // Создаём новый массив на 8 элементов
Console.WriteLine("ВВОДИТЬ ТОЛЬКО ЧИСЛА !!!");

int index = 0; // Наполняем
while (index < array.Length)
{
    Console.Write($"Введите элемент массива {index + 1}: ");
    int temp = Convert.ToInt32(Console.ReadLine());
    array[index] = temp;
    index++;
}
Console.WriteLine("Создан массив на 8 элементов");
Console.WriteLine("{ " + string.Join(", ", array) + " }");