// Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.

Console.Clear();
// Добавим рандома длинны массива от 2 до 40
int[] array = new int[new Random().Next(2, 41)];
int i = 0;
while (i <= (array.Length -1))
{
    array[i] = new Random().Next(0, 2);
    i++;
}
// Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"[{string.Join(", ", array)}]"); // вывод в [ ]