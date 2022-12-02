// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.

Console.Clear();

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int i = 1;

if (number == 0)
{
    Console.WriteLine("Ноль в любой степени будет 0");
}
// В случае если на вход пришло отрицательное число (-N)
// то выводим таблицу квадратов чисел от -N до -1
else if (number < 0)
{
    i = number;
    number = -1;
}
while (i <= number)
{
    double square = Math.Pow(i, 2);
    Console.Write($" {square} ");
    i++;
}