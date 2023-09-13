﻿// Задача 45: Напишите программу, которая будет создавать копию
// заданного массива с помощью поэлементного копирования.

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

int[] CopyArray(int[] array)
{
    int[] newArr = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArr[i] = array[i];
    }
    return newArr;
}

int[] array = CreateArrayRndInt(5,1,9);
PrintArray(array);
Console.WriteLine();

int[] copyArray = CopyArray(array);
PrintArray(copyArray);