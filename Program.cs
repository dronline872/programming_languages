
/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */
Console.WriteLine("Задача 2");
Console.WriteLine("Введите первое число:");
string strNumberOneTaskTwo = Console.ReadLine();
int intNumberOneTaskTwo = Convert.ToInt32(strNumberOneTaskTwo);

Console.WriteLine("Введите второе число:");
string strNumberTwoTaskTwo = Console.ReadLine();
int intNumberTwoTaskTwo = Convert.ToInt32(strNumberTwoTaskTwo);

Console.Write("Максимальное число: ");
if (intNumberOneTaskTwo > intNumberTwoTaskTwo) 
{
    Console.WriteLine(intNumberOneTaskTwo);
} 
else 
{
    Console.WriteLine(intNumberTwoTaskTwo);
}
Console.WriteLine("__________________________");

/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */
Console.WriteLine("Задача 4");
Console.WriteLine("Введите первое число:");
string strNumberOneTaskFour = Console.ReadLine();
int intNumberOneTaskFour = Convert.ToInt32(strNumberOneTaskFour);

Console.WriteLine("Введите второе число:");
string strNumberTwoTaskFour = Console.ReadLine();
int intNumberTwoTaskFour = Convert.ToInt32(strNumberTwoTaskFour);

Console.WriteLine("Введите третье число:");
string strNumberThreeTaskFour = Console.ReadLine();
int intNumberThreeTaskFour = Convert.ToInt32(strNumberThreeTaskFour);

Console.Write("Максимальное число: ");
if (intNumberOneTaskFour > intNumberTwoTaskFour) 
{
    if (intNumberOneTaskFour > intNumberThreeTaskFour) 
    {
        Console.WriteLine(intNumberOneTaskFour);
    } 
    else 
    {
        Console.WriteLine(intNumberThreeTaskFour);
    }
} 
else if (intNumberTwoTaskFour > intNumberThreeTaskFour) 
{
    Console.WriteLine(intNumberTwoTaskFour);
}
else
{
     Console.WriteLine(intNumberThreeTaskFour);
}
Console.WriteLine("__________________________");

/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */
Console.WriteLine("Задача 6");
Console.WriteLine("Введите число:");
string strNumberTaskSix = Console.ReadLine();
int intNumberOneTaskSix = Convert.ToInt32(strNumberTaskSix);
if (intNumberOneTaskSix % 2 == 0) 
{
    Console.WriteLine("Число четное");

} 
else 
{
    Console.WriteLine("Число нечетное");
}
Console.WriteLine("__________________________");

/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */
Console.WriteLine("Задача 8");
Console.WriteLine("Введите число:");
string strNumberTaskEight = Console.ReadLine();
int intNumberOneTaskEight = Convert.ToInt32(strNumberTaskEight);
int i = 1;

Console.WriteLine("Все чётные числа:");
while(i < intNumberOneTaskEight)
{
    i++;
    if (i % 2 == 0 ) {
        if (i > 2 ) 
        {
            Console.Write(", ");
        }

        Console.Write(i);
    }    
}