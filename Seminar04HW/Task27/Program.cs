// Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.

Console.Clear();

Console.WriteLine("Введите число 1 до 18 знаков: ");
long number = Convert.ToInt64(Console.ReadLine());

long temp = number;
long digit = 0;
long sum = 0;

while (temp > 0)
{
    digit = temp % 10;
    sum += digit;
    temp /= 10;
}
Console.WriteLine($"Сумма цифр в числе = {sum}");