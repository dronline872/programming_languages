/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */
Console.WriteLine("Задача 47");
 double[,] CreateDoubleMatrix(int row, int column, double min, double max)
{
    double[,] result = new double[row, column];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = min + rnd.NextDouble() * (max - min);
        }
    }

    return result;
}

void PrintDoubleMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j != 0)
            {
                Console.Write(", ");
            }

            Console.Write(matrix[i, j]);

        }

        Console.WriteLine();
    }
}

PrintDoubleMatrix(CreateDoubleMatrix(3, 4, -10, 10));
Console.WriteLine("");

/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */
Console.WriteLine("Задача 50");
int[,] CreateMatrix(int row, int column, int min, int max)
{
    int[,] result = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = rnd.Next(min, max);
        }
    }

    return result;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j != 0)
            {
                Console.Write(", ");
            }

            Console.Write(matrix[i, j]);
        }

        Console.WriteLine();
    }
}

void FindNumberInMatrix(int[,] matrix, int row, int column)
{
    if (row < 0
    || column < 0
    || row > matrix.GetLength(0)
    || column > matrix.GetLength(1))
    {
        Console.WriteLine("Такого числа в массиве нет");
        return;
    }

    Console.WriteLine($"Число в позиции [{row},{column}] = {matrix[row - 1, column - 1]}");
}

int[,] matrix = CreateMatrix(3, 4, 1, 10);
PrintMatrix(matrix);
Console.WriteLine("Введите номер строки:");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца:");
int col = Convert.ToInt32(Console.ReadLine());
FindNumberInMatrix(matrix, row, col);
Console.WriteLine("");
/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4 */
Console.WriteLine("Задача 52");
void FindAverageMatrix(int[,] matrix)
{  
    double[] result = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j, i];
        }

        result[i] = sum / matrix.GetLength(0);
    }

    Console.WriteLine($"Среднее арифметическое элементов: {String.Join(", ",result)}");
}
int[,] matrix2 = CreateMatrix(3, 4, 1, 10);
PrintMatrix(matrix2);
FindAverageMatrix(matrix2);
Console.WriteLine("");
/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */
Console.WriteLine("Задача 62");
void PrintSpiralMatrix(int row, int column)
{
    int[,] result = new int[row, column];
    int counter = 0;
    SpiralMatrix(0, 0, result);

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            if (j != 0)
            {
                Console.Write(", ");
            }

            if (result[i, j] < 10)
            {
                Console.Write(0);
            }
            Console.Write(result[i, j]);
        }

        Console.WriteLine();
    }
}

void SpiralMatrix(int row, int column, int[,] matrix, int counter = 1, string type = "right")
{
    if (row > matrix.GetLength(0) - 1
    || row < 0
    || column > matrix.GetLength(1) - 1
    || column < 0
    )
    {
        return;
    }


    if (matrix[row, column] == 0)
    {
        matrix[row, column] = counter;
        counter++;
        switch (type)
        {
            case "right":
                if ((column + 1 < matrix.GetLength(1)) && matrix[row, column + 1] == 0)
                {
                    SpiralMatrix(row, column + 1, matrix, counter, "right");
                }
                else if (row + 1 < matrix.GetLength(0))
                {
                    SpiralMatrix(row + 1, column, matrix, counter, "bottom");
                }
                break;
            case "bottom":
                if ((row + 1 < matrix.GetLength(0)) && matrix[row + 1, column] == 0)
                {
                    SpiralMatrix(row + 1, column, matrix, counter, "bottom");
                }
                else if (column - 1 > 0)
                {
                    SpiralMatrix(row, column - 1, matrix, counter, "left");
                }
                break;
            case "left":
                if ((column - 1 >= 0) && matrix[row, column - 1] == 0)
                {
                    SpiralMatrix(row, column - 1, matrix, counter, "left");
                }
                else if (row - 1 > 0)
                {
                    SpiralMatrix(row - 1, column, matrix, counter, "top");
                }
                break;
            case "top":
                if ((row - 1 >= 0) && matrix[row - 1, column] == 0)
                {
                    SpiralMatrix(row - 1, column, matrix, counter, "top");
                }
                else if (column + 1 < matrix.GetLength(1))
                {
                    SpiralMatrix(row, column + 1, matrix, counter, "right");
                }
                break;
        }




    }
}

PrintSpiralMatrix(4, 4);
Console.WriteLine("");