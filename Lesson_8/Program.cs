/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */
Console.WriteLine("Задача 54");
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
    Console.WriteLine();
}

void SortRowMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - j - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k];
                    matrix[i, k] = matrix[i, k + 1];
                    matrix[i, k + 1] = temp;
                }
            }
        }
    }
}

int[,] matrix = CreateMatrix(3, 4, 1, 10);
PrintMatrix(matrix);
SortRowMatrix(matrix);
PrintMatrix(matrix);


/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */
Console.WriteLine("Задача 56");
void SmallSumRow(int[,] matrix)
{
    int result = 0;
    int min = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           sum += matrix[i, j];
        }

        if (min == 0 || sum < min) {
            min = sum;
            result = i;
        }  
    }

    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {result + 1}");
}


int[,] matrix2 = CreateMatrix(4, 4, 1, 10);
PrintMatrix(matrix2);
SmallSumRow(matrix2);

/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */
Console.WriteLine("Задача 58");
int[,] MatrixMultiply(int[,] matrixA, int[,] matrixB)
{
    int rowsA = matrixA.GetLength(0);
    int colsA = matrixA.GetLength(1);
    int rowsB = matrixB.GetLength(0);
    int colsB = matrixB.GetLength(1);

    int[,] matrixC = new int[rowsA, colsB];

    for (int i = 0; i < rowsA; i++)
    {
        for (int j = 0; j < colsB; j++)
        {
            int sum = 0;

            for (int k = 0; k < colsA; k++)
            {
                sum += matrixA[i, k] * matrixB[k, j];
            }

            matrixC[i, j] = sum;
        }
    }

    return matrixC;
}

int[,] matrixA = CreateMatrix(2, 2, 1, 10);
int[,] matrixB = CreateMatrix(2, 2, 1, 10);
Console.WriteLine("Матрица 1:");
PrintMatrix(matrixA);
Console.WriteLine("Матрица 2:");
PrintMatrix(matrixB);
int[,] matrixC = MatrixMultiply(matrixA, matrixB);
Console.WriteLine("Результат произведения матриц:");
PrintMatrix(matrixC);

/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */
Console.WriteLine("Задача 60");
int[,,] CreateThreeDimensionalArray(int sizeA, int sizeB, int sizeC) 
{
    int[,,] result = new int[sizeA, sizeB, sizeC];
    int counter = 10;
    for (int i = 0; i < sizeA; i++)
    {
        for (int j = 0; j < sizeB; j++)
        {
            for (int k = 0; k < sizeC; k++)
            {
                result[i, j, k] = counter;
                counter++;
            }
        }
    }

    return result;
}

void PrintThreeDimensionalArray(int[,,] arr) 
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i,j,k]}({i},{j},{k}) ");   
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] array = CreateThreeDimensionalArray(2,2,2);
PrintThreeDimensionalArray(array);