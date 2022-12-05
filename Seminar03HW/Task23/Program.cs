// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();

// Добавим сложности.
// 1. Дополнительно на вход принимаем степень включая отрицательное значение.
// 2. Вычисляем возведение в степень без Math.Pow().
// 3. Дополнительно на вход принимаем отрицательное число (-N)
// и выводим таблицу степеней чисел от -N до -1.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень: ");
int pow = Convert.ToInt32(Console.ReadLine());

int start = 1; // Начинаем с '1'

double Exponent() // Вычисляем возведение в степень
{
    int i = 1;
    double exp = start;
    while (i < pow)
    {
        exp = exp * start;
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
else if (number > 0 && pow > 0) // Положительное число + Положительная степень
{
    Console.WriteLine($"Таблица возведения чисел от 1 до {number} в степень {pow}:");
    while (start <= number)
    {
        Console.Write(" " + $"{Exponent()}" + " ");
        start++;
    }
}
else if (number < 0 && pow > 0) // Отрицательное число + Положительная степень
{
    start = number;
    number = -1;
    Console.WriteLine($"Таблица возведения чисел от {start} до -1 в степень {pow}:");
    while (start <= number)
    {
        Console.Write(" " + $"{Exponent()}" + " ");
        start++;
    }
}
else if (number > 0 && pow < 0) // Положительное число + Отрицательная степень
{
    pow = -pow;
    Console.WriteLine($"Таблица возведения чисел от 1 до {number} в степень {-pow}:");
    while (start <= number)
    {
        Console.Write(" " + $"{1 / Exponent()}" + " ");
        start++;
    }
}
else if (number < 0 && pow < 0) // Отрицательное число + Отрицательная степень
{
    start = number;
    number = -1;
    pow = -pow;
    Console.WriteLine($"Таблица возведения чисел от {start} до -1 в степень {-pow}:");
    while (start <= number)
    {
        Console.Write(" " + $"{1 / Exponent()}" + " ");
        start++;
    }
}