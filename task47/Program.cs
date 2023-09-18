// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

double[,] CreateMaxrixRndDouble(int rows, int columns, double min, double max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.NextDouble()*(max-min)+min;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 4 :F1}");
        }
        Console.WriteLine();
    }
}
double[,] array2d = CreateMaxrixRndDouble(4, 4, 1, 10);
PrintMatrix(array2d);