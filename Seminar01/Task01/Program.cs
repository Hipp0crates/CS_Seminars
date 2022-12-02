// Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго.

Console.WriteLine("Введите число 1: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB * numberB == numberA)
{
    Console.WriteLine($"{numberB} * {numberB} = {numberA}");
}
else
{
    Console.WriteLine($"{numberB} * {numberB} не получается {numberA}");
}