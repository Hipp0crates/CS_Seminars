// Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int m, int n)
{
    int sum = m;
    if (m == n)
    {
        return m;
    }
    sum = n + SumNumbers(m, (n - 1));
    return sum;
}

Console.WriteLine($"Сумма натуральных чисел в промежутке от {m} до {n} = {SumNumbers(m, n)}");