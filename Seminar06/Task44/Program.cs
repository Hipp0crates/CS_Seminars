// Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.

Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] name = new int[n];
name[0] = 0;
name[1] = 1;

for (int i = 2; i < n; i++)
{
    name[i] = name[i-2] + name[i-1];
}
Console.WriteLine(string.Join(" ", name));

// Второй вариант
void Check(int m)
{
    int numberOne = 0;
    int numberTwo = 1;
    for (int i = 0; i < n; i++)
    {
        Console.Write(numberOne + " ");
        int x = numberOne + numberTwo;
        numberOne = numberTwo;
        numberTwo = x;
    }
}
Console.WriteLine("Введите колличество символов");
int m = int.Parse(Console.ReadLine()!);
Check(n);