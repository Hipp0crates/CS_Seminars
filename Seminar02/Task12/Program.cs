// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.Clear();

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 % number2 == 0)
{
    Console.WriteLine($"{number2} является кратным {number1}");
}
else
{
    Console.Write($"{number2} не является кратным {number1}");
    Console.Write(" - остаток от деления: " + (number1 % number2));
}