// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.Clear();

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int even = 2;

// Добавим сложности: число (N) может быть отрицательным
// и на выходе будут все четные числа от -N до -1.

if (number % 2 > 0 && number > 0)
{
    number = number - 1;
}
else
{
    even = number + 1;
    number = -2;
}
while (even <= number)
{
    Console.Write($" {even} ");
    even += 2;
}