// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

Console.Clear();

Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());

int Numbers(int m)
{
    int sum = 0;
    if (m == 0)
    {
        return 0;
    }
    sum = Numbers(m / 10) + m % 10;
    return sum;
}

int sum = Numbers(m);
Console.WriteLine(sum);