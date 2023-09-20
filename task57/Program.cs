// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int[] MatrixToArray(int[,] matrix)
{
    int[]array = new int [matrix.Length];
    int k = 0;
    for (int i = 0; i<matrix.GetLength(0); i++)
    {
        for (int j = 0; j<matrix.GetLength(1); j++)
        {
            array[k++] = matrix[i,j];
        }
    }
    return array;

}

void DictionaryFreq(int[]arr)
{
    int count =1;
    int curNum = arr[0];
    for (int i = 0; i<arr.Length; i++)
    {
        if (arr[i] == curNum) count++;
        else
        {
            Console.WriteLine($"Частота встречаемости элемента {curNum}: {count}");
            curNum = arr[i];
            count = 1;
        }
    }
    Console.WriteLine ($"Частота встречаемости элемента {curNum}: {count}");
}

int[,] array2d = CreateMaxrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);
Console.WriteLine();
int[]array = MatrixToArray(array2d);
Array.Sort(array);
PrintArray(array);
Console.WriteLine();
DictionaryFreq(array);