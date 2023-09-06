// программа выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке

// int[] array = new int[8];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(2);
//     Console.Write(array[i] + " ");
// }


// int[] array = new int[8];
// Random rnd = new Random();
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rnd.Next(2);
//     Console.Write(array[i] + " ");
// }

void FillArray(int[]array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(2);
    }
}

void PrintArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
     Console.Write(array[i] + " ");   
    }
}

int[]arr = new int[8];
FillArray(arr);
PrintArray(arr);
