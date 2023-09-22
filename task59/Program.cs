// Задача 59: Задайтедвумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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

int[] FindPosMinElem(int[,] matrix)
{
    int minElemRow = 0;
    int minElemColumn = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[minElemRow, minElemColumn])
            {
                minElemRow = i;
                minElemColumn = j;
            }
        }
    }
    return new int[] { minElemRow, minElemColumn };
}

int[,] NewMatrixNoMinElem(int[,] matrix, int delRow, int delColumn)
{
    int m = 0, n = 0;
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        n = 0;
        if (m == delRow) m = m+1;
        for (int j = 0; j < newMatrix.GetLength(1); i++)
        {
            if (n == delColumn) n = n+1;
            newMatrix[i, j] = matrix[m, n];
            n++;
        }
        m++;
    }
    return newMatrix;
}
int[,] array2d = CreateMaxrixRndInt(4, 4, 1, 5);
PrintMatrix(array2d);
Console.WriteLine();
int[] findPosMinElem = FindPosMinElem(array2d);
int [,] newMatrixNoMinElem = NewMatrixNoMinElem(array2d, findPosMinElem[0], findPosMinElem[1]);
Console.WriteLine();
PrintMatrix(newMatrixNoMinElem);