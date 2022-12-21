// Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.Clear();

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

void Numbers(int m, int n)
{
    if (n < m)
    {
        return;
    }
    Numbers(m, n - 1);
    Console.Write(n + "  ");
}

Numbers(m, n);