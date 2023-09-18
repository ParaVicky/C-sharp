// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

int[,] CreateMaxrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine();
    }
}

void FindNumber(int[,] matrix, int m, int n)
{
    if (m > matrix.GetLength(0) || n > matrix.GetLongLength(1))
    {
        Console.WriteLine("Указанный элемент в массиве отсутствует");
    }
    if (m < matrix.GetLength(0) && n < matrix.GetLength(1))
    {
        Console.WriteLine($"Значение элемента на указанной позиции = {matrix[m, n]}");
    }
}
int[,] array2d = CreateMaxrixRndInt(3, 4, -100, 100);
PrintMatrix(array2d);
Console.WriteLine("введите номер строки");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());
FindNumber(array2d, m, n);