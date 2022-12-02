// Напишите программу, которая принимает на вход цифру, обозначающую день недели.
// И проверяет, является ли этот день выходным.

Console.Clear();

Console.WriteLine("Введите номер дня недели от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 7 || number < 1)
{
    Console.WriteLine("Нет такого дня недели");
}
else
{
    if (number == 1) Console.Write("Понедельник");
    if (number == 2) Console.Write("Вторник");
    if (number == 3) Console.Write("Среда");
    if (number == 4) Console.Write("Четверг");
    if (number == 5) Console.Write("Пятница");
    if (number == 6) Console.Write("Суббота");
    if (number == 7) Console.Write("Воскресенье");
    if (number > 5)
    {
        Console.Write(" - выходной день");
    }
    else
    {
        Console.Write(" - не является выходным днём");
    }
}