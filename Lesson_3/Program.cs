/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */
Console.WriteLine("Задача 19");
Console.WriteLine("Введите число:");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = number1;
int invert = 0;
while (true)
{ 
    invert = (invert * 10) + (number2 % 10);
    number2 = number2 / 10;
    if (number2 < 1) {
        if (number1 == invert) {
            Console.WriteLine("Число является палиндромом");
        } else {
            Console.WriteLine("Число не является палиндромом");
        }

        break;
    }
}

/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */
Console.WriteLine("Задача 21");
Console.WriteLine("Введите координаты точки A");
Console.WriteLine("Координата x");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Координата y");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Координата z");
double zA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.WriteLine("Координата x");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Координата y");
double yB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Координата z");
double zB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Расстояние между точками: {Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2) + Math.Pow((zB - zA), 2))}");

/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */
Console.WriteLine("Задача 23");
Console.WriteLine("Введите число:");
int number3 = Convert.ToInt32(Console.ReadLine());
double number4 = 1;
while (number4 <= number3)
{
    Console.Write(Math.Pow(number4, 3) + " ");
    number4++;
}