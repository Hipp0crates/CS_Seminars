// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// Не использовать Math.Pow() и аналоги!

Console.Clear();

// Добавим сложности.
// Дополнительно на вход принимаем отрицательные значение (-A) и (-B).

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень: ");
int pow = Convert.ToInt32(Console.ReadLine());

double Exponent() // Вычисляем возведение в степень
{
    int i = 0;
    double exp = 1;
    while (i < pow)
    {
        exp = exp * number;
        i++;
    }
    return exp;
}

if (pow == 0) // Любое число в степени '0' будет равно '1'
{
    Console.WriteLine($"{number} в степени {pow} = 1");
}
else if (number == 0 && pow > 0) // '0' в любой положительной степени будет '0'
{
    Console.WriteLine($"{number} в степени {pow} = 0");
}
else if (number == 0 && pow < 0) // '0' в любой отрицательной степени не имеет смысла
{
    Console.WriteLine($"{number} в степени {pow} не имеет смысла");
}
else if (pow > 0) // Положительная степень
{
    Console.Write($"{number} в степени {pow} = {Exponent()}");
}
else if (pow < 0) // Отрицательная степень
{
    pow = -pow;
    Console.Write($"{number} в степени {-pow} = {1 / Exponent()}");
}