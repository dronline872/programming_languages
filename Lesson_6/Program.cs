/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */
Console.WriteLine("Задача 41");
int WriteNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintIntArray(int[] array)
{
    Console.WriteLine($"Массив [{String.Join(", ", array)}]");
}

int[] CreateArray(string text, int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = WriteNumber(text);
    }

    return result;
}

int CountNumber(int[] array)
{
    int result = 0;
    foreach (int item in array)
    {
        if (item > 0)
        {
            result++;
        }
    }

    return result;
}

int size = WriteNumber("Введите количество элементов массива");
int[] array = CreateArray("Введите число", size);
PrintIntArray(array);
Console.WriteLine($"Количество чисел больше нуля в массиве: {CountNumber(array)}");

/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */
Console.WriteLine("Задача 43");
double WriteDoubleNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToDouble(Console.ReadLine());
}
void FindingPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = (k1 * x) + b1;
    Console.WriteLine($"Точка пересечения: ({x}, {y})");
}
double b1 = WriteDoubleNumber("Введите b1");
double k1 = WriteDoubleNumber("Введите k1");
double b2 = WriteDoubleNumber("Введите b2");
double k2 = WriteDoubleNumber("Введите k2");
FindingPoint(b1, k1, b2, k2);

/* Задача 44:выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5
--> 0 1 1 2 3
Если N = 3
--> 0 1 1
Если N = 7
--> 0 1 1 2 3 5 8 */

void Fibonacci(int n) {
    int[] result = new int[n]; 
    for (int i = 0; i < n; i++)
    {
        if (i == 0 || i == 1) {
            result[i] = i;
        } else {
            result[i] = result[i-2] + result[i-1];
        }
    }

    Console.WriteLine($"Фибоначи: {String.Join(", ", result)}");
}

Fibonacci(WriteNumber("Введите N:"));