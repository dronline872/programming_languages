/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */
Console.WriteLine("Задача 25");
int WriteNumber(string text) {
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Pow(int number1, int number2) {
    int result = number1;
    for (int i = 1; i < number2; i++)
    {
        result *= number1;
    }

    return result;
}

int number1 = WriteNumber("Введите первое число:");
int number2 = WriteNumber("Введите второе число:");
int result = Pow(number1, number2);

Console.WriteLine($"Число {number1} в степени {number2} = {result}");


/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */
Console.WriteLine("Задача 27");
int number3 = WriteNumber("Введите число:");

int SumNumbers(int number) {
    int result = 0;
    int temp = number;
    while (temp > 0)
    {
       result += temp % 10;
       temp /= 10;
    }

    return result;
}

int resultSum = SumNumbers(number3);
Console.WriteLine($"Сумма чисел: {resultSum}");

/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */
Console.WriteLine("Задача 29");
int lengthArray = WriteNumber("Длина массива:");
int fromArray = WriteNumber("Начальное значение:");
int toArray = WriteNumber("Конечное значение:");

int[] GenerateArray(int lengthArray, int fromArray, int toArray) {
    int[] result = new int[lengthArray];
    Random rnd = new Random();
    for (int i = 0; i < lengthArray; i++)
    {
        result[i] = rnd.Next(fromArray, toArray);
    }

    return result;
}

int[] resultArray = GenerateArray(lengthArray,  fromArray, toArray);

Console.WriteLine($"Массив [{String.Join(", ",resultArray)}]");