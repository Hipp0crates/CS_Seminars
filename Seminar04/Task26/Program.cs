// Напишите программу, которая принимает на вход число
// и выдаёт количество цифр в числе.

Console.Clear();

Console.WriteLine("Введите число: ");
long number = Convert.ToInt64(Console.ReadLine());
int count = 0;
if(number < 0) number = -number;

while (number > 0)
{
    number /= 10;
    count++;
}
Console.WriteLine($"Количество чисел {count}");