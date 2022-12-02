// Напишите программу, которая принимает на вход число N
// и выдаёт произведение чисел от 1 до N (факториал).

Console.Clear();

Console.WriteLine("Введите чмсло: ");
int number = Convert.ToInt32(Console.ReadLine());
double mult = 1;

if (number >= 0)
{
    int i = 1;
    while (i <= number)
    {
        mult *= i;
        i++;
    }
    Console.WriteLine($"{number}! = {mult}");
}
else
{
    Console.WriteLine("Введите положительное число");
}