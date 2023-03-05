/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */
Console.WriteLine("Задача 64");
string NaturalNumbers(int number)
{
    string result = "";
    if (number > 0)
    {
        result += $"{number}";
        if (number != 1)
        {
            result += ", ";
        }

        result += NaturalNumbers(number - 1);
    }

    return result;
}

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
string naturalNumbers = NaturalNumbers(number);
Console.WriteLine($"N = {number} -> \"{naturalNumbers}\"");

/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
Console.WriteLine("Задача 66");
int SumNaturalNumbers(int m, int n)
{

    if (m == n)
    {
        return m;
    }
    else
    {
        return SumNaturalNumbers(m, n - 1) + n;
    }
}

Console.WriteLine($"M = 1; N = 15 -> {SumNaturalNumbers(1, 15)}");
Console.WriteLine($"M = 4; N = 8 -> {SumNaturalNumbers(4, 8)}");

/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */
Console.WriteLine("Задача 68");
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}

Console.WriteLine($"m = 2, n = 3 -> {Akkerman(2, 3)}");
Console.WriteLine($"m = 3, n = 2 -> {Akkerman(3, 2)}");