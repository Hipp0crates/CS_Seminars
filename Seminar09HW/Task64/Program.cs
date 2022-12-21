// Задайте значение N.
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

Console.Clear();

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 0;

void Numbers(int n, int m)
{
    if (n == m)
    {
        return;
    }
    Numbers(n, m + 1);
    Console.Write(m + 1 + "  ");
}

Console.WriteLine($"Натуральные числа в промежутке от {n} до 1:");
Numbers(n, m);