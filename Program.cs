// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*Console.WriteLine("введите количество строк");
int m  = int.Parse(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int n  = int.Parse(Console.ReadLine());
double[,] MyArray = GetArray(m, n);
PrintArray(MyArray);*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет. Например, задан массив:

double[,] MyArray = GetArray(10, 10);
PrintArray(MyArray);
Console.WriteLine("Введите позицию элемента по строке");
int m  = int.Parse(Console.ReadLine());
Console.WriteLine("Введите позицию элемента по столбцу");
int n  = int.Parse(Console.ReadLine());
PrintElement(m, n, MyArray);



void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}

double[,] GetArray(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            double f = new Random().NextDouble();
            array[i,j] = Math.Round(f, 2);
            
        }
    }
    return array;
}

void PrintElement(int x, int y, double[,] array)
{
    if (x <= array.GetLength(0) - 1  && x >= 0 && y <= array.GetLength(1) - 1 && y >= 0 )  
    {Console.WriteLine(array[x,y]);}
    else {Console.WriteLine("Элемента с заданной позицией нет");}
}