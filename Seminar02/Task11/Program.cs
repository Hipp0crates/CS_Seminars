// Напишите программу, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа.

Console.Clear();

int number = new Random().Next(100, 1000);
Console.Write(number);
int digit2 = number % 10;
int digit1 = (number / 100) * 10;

Console.Write($" -> {digit1 + digit2}");