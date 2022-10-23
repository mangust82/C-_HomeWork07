// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*Console.WriteLine("введите количество строк");
int m  = int.Parse(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int n  = int.Parse(Console.ReadLine());
double[,] MyArray = GetArray(m, n);
PrintArray(MyArray);*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет. Например, задан массив:

/*double[,] MyArray = GetArray(10, 10);
PrintArray(MyArray);
Console.WriteLine("Введите позицию элемента по строке");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите позицию элемента по столбцу");
int n = int.Parse(Console.ReadLine());
PrintElement(m, n, MyArray);*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] MyArray = GetIntArray(4, 10);
PrintIntArray(MyArray);
double[] Avg = AverageArray(MyArray);
Console.WriteLine("Среднее по столбцам");
Console.WriteLine(String.Join(", ", Avg));



void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[,] GetArray(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double f = new Random().NextDouble();
            array[i, j] = Math.Round(f, 2);

        }
    }
    return array;
}

void PrintElement(int x, int y, double[,] array)
{
    if (x <= array.GetLength(0) - 1 && x >= 0 && y <= array.GetLength(1) - 1 && y >= 0)
    { Console.WriteLine(array[x, y]); }
    else { Console.WriteLine("Элемента с заданной позицией нет"); }
}

int[,] GetIntArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 101);

        }
    }
    return array;
}

void PrintIntArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[] AverageArray(int[,] array)
{
    double[] AvgArr = new double[array.GetLength(1)];
    for (int j = 0; j <= array.GetLength(1)-1; j++)
    {
        double avg = 0;
        for (int i = 0; i <= array.GetLength(0)-1; i++)
        {
            avg = avg + (double) array[i, j] / array.GetLength(0);
        }
        AvgArr[j] = Math.Round(avg, 4);
    }
    return AvgArr;
}