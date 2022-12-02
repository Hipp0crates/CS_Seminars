// Напишите программу, которая на вход принимает число и выдает,
// является ли число четным (делится ли оно на два без остатка).

Console.Clear();

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine($"число {number} четное");
}
else
{
    Console.WriteLine($"число {number} нечетное");
}