// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

Console.Clear();

Console.WriteLine("Введите два неотрицательных числа: m и n.");
Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());

int AckermannFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return AckermannFunction(m - 1, 1);
    else return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

void AckermannPrint(int m, int n)
{
    Console.WriteLine("Вычисление функции Аккермана:");
    if (m == 0) Console.WriteLine("A(m, n) = n + 1");
    else if (m > 0 && n == 0) Console.WriteLine("A(m, n) = A(m - 1, 1)");
    else Console.WriteLine("A(m, n) = A(m - 1, A(m, n - 1))");
}

AckermannPrint(m, n);
Console.WriteLine($"A({m}, {n}) = {AckermannFunction(m, n)}");