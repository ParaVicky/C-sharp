// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Укажите размер массива");
int arraySize = Convert.ToInt32(Console.ReadLine());

int[] UserArray (int arraySize)
{
    int[] array = new int[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        Console.WriteLine("Введите элемент массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
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

int MoreThatZero(int[]arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>0) count++;        
    }
    return count;
}

int [] userArray = UserArray(arraySize);


PrintArray(userArray);
Console.WriteLine();

int moreThanZero = MoreThatZero(userArray);
Console.WriteLine($"Количество элементов больше нуля вашем массиве = {moreThanZero}");
