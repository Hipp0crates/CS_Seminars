// Задайте значение N.
// Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

Console.Clear();

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

void Numbers(int number)
{
    if (number == 0)
    {
        return;
    }
    Numbers(number - 1);
    Console.Write(number + "  ");
}

Numbers(n);