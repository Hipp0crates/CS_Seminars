// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает последнюю цифру этого числа.

Console.WriteLine("Ведите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number < 1000)
{
    int ostatok = number % 10;
    Console.WriteLine(ostatok);
}
else
{
    Console.WriteLine("Введено не трехзначное число!");
}