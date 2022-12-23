// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

int SecondDigit(int number)
{
    int digit1 = number / 100;
    int num = number - (digit1 * 100);
    int result = num / 10;
    return result;
}

int SecondD = SecondDigit(number);
Console.WriteLine($"Вторая цифра числа {number} равна {SecondD}");