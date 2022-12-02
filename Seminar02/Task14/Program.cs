// Напишите программу, которая принимает на вход число
// и проверяет, кратно ли оно одновременно 7 и 23.

Console.Clear();

Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 % 7 == 0 && number1 % 23 == 0)
{
    Console.WriteLine("Число кратное одновременно и 7 и 23");
}
else
{
    Console.WriteLine("Число не кратное одновременно и 7 и 23");
}