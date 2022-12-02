// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.

Console.Clear();

int number = new Random().Next(10, 100);
Console.Write(number);
int digit2 = number % 10;
int digit1 = number / 10;

if (digit1 > digit2)
{
    Console.WriteLine($" -> цифра {digit1} наибольшая");
}
else
{
    Console.WriteLine($" -> цифра {digit2} наибольшая");
}