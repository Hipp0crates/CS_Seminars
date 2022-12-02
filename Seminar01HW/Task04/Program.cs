// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

Console.Clear();

Console.WriteLine("Введите число 1: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 3: ");
int numberC = Convert.ToInt32(Console.ReadLine());

int maxNumber = numberA;

if (maxNumber < numberB) maxNumber = numberB;
if (maxNumber < numberC) maxNumber = numberC;

Console.WriteLine($"число {maxNumber} максимальное");