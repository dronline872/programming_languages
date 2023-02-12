/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */
Console.WriteLine("Задача 34");
int[] GenerateArray(int lengthArray, int min, int max) {
    if (min > max) {
        return Array.Empty<int>();
    }

    int[] result = new int[lengthArray];
    Random rnd = new Random();
    for (int i = 0; i < lengthArray; i++)
    {
        result[i] = rnd.Next(min, max);
    }

    return result;
}

void PrintIntArray(int[] array) {
    Console.WriteLine($"Массив [{String.Join(", ",array)}]");
}

int CountEventNumber(int[] array) {
    int result = 0;
    foreach(int el in array) {
        if (el % 2 == 0) {
            result++;
        }
    }

    return result;
}

int[] array = GenerateArray(4, 234, 897);
PrintIntArray(array);
Console.WriteLine($"Количество чётных чисел {CountEventNumber(array)}");

/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */
Console.WriteLine("Задача 36");
int SumNumbers(int[] array) {
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) 
        { 
            result += array[i];
        }
    }

    return result;
}

int[] array2 = GenerateArray(6, -8, 10);
PrintIntArray(array2);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях {SumNumbers(array2)}");

/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */
Console.WriteLine("Задача 38");
double[] GenerateArrayDouble(int length, double min, double max )
{ 
    if (min > max) 
    {
        return Array.Empty<double>();
    }

    double[] result = new double[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        result[i] = min + rnd.NextDouble()*(max-min);
    }
    
    return result;
}

double Diff(double[] array) {
    double min = array[0];
    double max = array[0];
    foreach (double el in array) {
        if (min > el) {
            min = el;
        } else {
            max = el;
        }
    }

    return max - min;
}

void PrintDoubleArray(double[] array) {
    Console.WriteLine($"Массив [{String.Join(", ",array)}]");
}

double[] array3 = GenerateArrayDouble(5, 2, 17);
PrintDoubleArray(array3);
Console.WriteLine($"Разницу между максимальным и минимальным элементом массива: {Diff(array3)}");