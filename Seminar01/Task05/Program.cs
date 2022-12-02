// Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Введите ваше число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = -number; i <= number; i += 1)
{
    Console.Write(i);
    Console.Write(" ");
}