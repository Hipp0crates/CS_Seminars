// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Ввод чисел останавливается при помощи ввода стоп-слова "stop"

Console.Clear();

Console.Write("Введите количество вводимых чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] enteredNumbers = new int[m];

void InputNumbers(int m, string stopWord) // Ввод чисел пользователем
{
    Console.WriteLine($"Для остановки ввода наберите: {stopWord}");
    int i = 0;
    while (i < m)
    {
        Console.Write($"Введите число {i + 1}: ");
        string? input = Console.ReadLine();
        if (input == stopWord) break;
        bool verification = int.TryParse(input, out int number);
        if (verification == true)
        {
            enteredNumbers[i] = number;
            i++;
        }
        else
        {
            Console.WriteLine("Введенные вами символы не являются числом");
        }
    }
}

int GreaterThanZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count += 1;
    }
    return count;
}

InputNumbers(m, "stop"); // Тут можно поменять стоп-слово
Console.WriteLine($"Введено чисел больше 0: {GreaterThanZero(enteredNumbers)}");