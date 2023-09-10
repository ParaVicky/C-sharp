// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
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

int SumOfOddIndexElements(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i = i+2)
    {
        sum = sum + arr[i];
    }
    return sum;
}

int[] array = CreateArrayRndInt(15, 100, 999);
PrintArray(array);
Console.WriteLine();

int sumOfOddIndexElements = SumOfOddIndexElements(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях, = {sumOfOddIndexElements}");
