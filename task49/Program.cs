﻿/*Задача 49: Задайте двумерный массив. Найдите элементы, у
которых оба индекса чётные, и замените эти элементы на их
квадраты.
*/
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

void EvenIndexReplaceToSquares (int[,] matrix)
{
    for (int i = 0; i<matrix.GetLength(0); i++)
    {
        for (int j = 0; j<matrix.GetLength(1); j++)
        {
            if (i%2 ==0 && j %2 ==0)
            {
                matrix[i,j] *= matrix[i,j];
            }
        }
    }
}

int[,] array2d = CreateMaxrixRndInt(3, 4, -10, 10);
PrintMatrix(array2d);
Console.WriteLine();
EvenIndexReplaceToSquares(array2d);
PrintMatrix(array2d);