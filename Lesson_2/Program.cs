// See https://aka.ms/new-console-template for more information

/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */
Console.WriteLine("Задача 10");
Console.WriteLine("Введите трехзначное число:");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = (number1 % 100) / 10;
Console.WriteLine($"Вторая цифра: {number2}");

/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine("Задача 13");
Console.WriteLine("Введите число:");
int number3 = Convert.ToInt32(Console.ReadLine());
while (true)
{ 
    if (number3 < 100) {
         Console.WriteLine("В числе меньше трех цифр");
        break;
    }

    if (number3 < 1000) {
        Console.WriteLine($"Третья цифра числа: {number3 % 10}");
        break;
    }

    number3 /= 10;
}

/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */
Console.WriteLine("Задача 15");
Console.WriteLine("Введите номер дня недели:");
int number4;
while(true) {
    number4 = Convert.ToInt32(Console.ReadLine());
    if (number4 < 1 || number4 > 7) {
        Console.WriteLine("Введите число от 1 - 7 ");
    } else {
        break;
    }
}

switch (number4)
{
    case 6:
    case 7:
    Console.WriteLine("Выходной день");
    break;
    default:
    Console.WriteLine("Не выходной день");
    break;
}