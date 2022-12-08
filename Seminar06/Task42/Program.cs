// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

Console.Clear();

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int number = a;

int Doit(int number)
{
    int i = 0;
    while (number > 0)
    {
        number = number / 2;
        i++;
    }
    return i;
}

int[] box = new int[Doit(number)];
int b = box.Length - 1;

while (number > 0)
{
    box[b] = number % 2;
    number = number / 2;
    b--;
}
Console.WriteLine($"{a} в двоичном исчислении: " + string.Join("", box));

// Воторой способ (рекурсия)
void PrintBinary(int num)
{
    if (num <= 0) return;
    PrintBinary(num / 2);
    Console.Write(num % 2);
}
PrintBinary(a);