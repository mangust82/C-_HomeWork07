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

/*int[,] MyArray = GetIntArray(4, 10);
PrintIntArray(MyArray);
double[] Avg = AverageArray(MyArray);
Console.WriteLine("Среднее по столбцам");
Console.WriteLine(String.Join(", ", Avg));*/

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет 
// построчно выводить массив, добавляя индексы каждого элемента.Массив размером 2 x 2 x 2

/*int[,,] myarr = GetThreeArray(2,2,2);
PrintThreeArray(myarr);*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

PrintSpiralArray(Snake(4,4));

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

int[,,] GetThreeArray(int m, int n, int p)
{
    int[,,] array = new int[m, n, p];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k=0; k < p; k++)
            {
                array[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
    return array;
}

void PrintThreeArray(int [,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}

void PrintSpiralArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j].ToString("000")} ");
        }
        Console.WriteLine();
    }
}

int[,] Snake(int row, int col)
{
    int j = 0; //строки
    int i = 0; //столбцы
    int n = 0; //счетчик общего количества элементов
    int k = 1; //счетчик уменьшения индекса строки столбца при проходе
    int p = 0; //счетчик уменьшения индекса строки при движении вверх
    int[,] array = new int[row,col];
    int M = array.GetLength(1)*array.GetLength(0);
    while(n < array.GetLength(1)*array.GetLength(0)-1)
    {
        
        for ( ; i < array.GetLength(1)-k ; i++, n++)
            {
                if (n >= M) break;
                array[j,i] = n;
                
            }
        for ( ; j < array.GetLength(0)-k; j++, n++)
            {
                if (n >= M) break;
                array[j,i] = n;
            }
        
        for ( ; i > p; i--, n++)
            {
                if (n >= M) break;
                array[j,i] = n;
            }
            
        for ( ; j >k; j--, n++)
            {
                
                if (n >= M) break;
                array[j,i] = n;
            }
        k++;
        p++;   
    }
    array[j,i] = n;
    return array;
}
