// Напишите программу, которая на вход принимает два числа
// и выдает, какое число большее, а какое меньшее.

Console.Clear();

Console.WriteLine("Введите число 1: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine($"{numberA} больше {numberB}");
}
else
{
    if (numberA < numberB)
    {
        Console.WriteLine($"{numberA} меньше {numberB}");
    }
    else
    {
        Console.WriteLine($"{numberA} равно {numberB}");
    }
}