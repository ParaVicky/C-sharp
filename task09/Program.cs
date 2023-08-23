// написать программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа
// 78 -> 8
// 12 -> 2
// 85 -> 8

int number = new Random().Next(10,99+1);
Console.WriteLine($"случайное число из диапазона 10-99 -> {number}");

// int firstDigit = number/10;
// int secondDigit = number%10;

// if (firstDigit > secondDigit)
// {
//     Console.WriteLine($"наибольшая цифра числа {number} -> {firstDigit}");
// }
// else
// {
//     Console.WriteLine($"наибольшая цифра числа {number} -> {secondDigit}");
// }


// Console.WriteLine(MaxDigit);

int MaxDigit (int number)
{
    int firstDigit = number /10;
    int secondDigit = number %10;
    if(firstDigit>secondDigit) return firstDigit;
    return secondDigit;
}
int maxDigit = MaxDigit(number);
Console.WriteLine($"наибольшая цифра числа {number} -> {maxDigit}");


