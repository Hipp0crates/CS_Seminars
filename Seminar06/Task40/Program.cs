// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника:
// каждая сторона треугольника меньше суммы двух других сторон.

Console.Clear();

Console.Write("1 число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("2 число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("3 число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a < b + c && b < a + c && c < a + b)
{
    Console.WriteLine("Есть такой треугольник");
}
else
{
    Console.WriteLine("Нет такого треугольника");
}