// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

Console.Clear();

Console.WriteLine("Ведите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number < 1000)
{
    int secondnumber = (number % 100) / 10;
    Console.WriteLine("Вторая цифра: " + secondnumber);
}
else
{
    Console.WriteLine("Введено не трехзначное число");
}