// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("введите количество строк");
int m  = int.Parse(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int n  = int.Parse(Console.ReadLine());
double[,] MyArray = GetArray(m, n);
PrintArray(MyArray);

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