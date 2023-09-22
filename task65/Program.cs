// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Введите число M");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int numN = Convert.ToInt32(Console.ReadLine());
if (numM < 1 || numN < 1)
{
    Console.WriteLine("Ошибка ввода данных");
    return;
}
void NaturalNumbers (int numberM, int numberN)
{
    // if (numberM == numberN)
    // {
    //     Console.Write(numberN);
    //     return;
    // }
    if (numberM>numberN)
    {
        Console.Write($"{numberM} ");
        NaturalNumbers(numberM-1, numberN);
    }
    else if (numberM<numberN)
    {
        Console.Write($"{numberM} ");
        NaturalNumbers(numberM+1, numberN);
    }
    else Console.Write($"{numberM}");
}
NaturalNumbers(numM, numN);
