// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int DecimalToBinary(int num)
{
    int result = 0;
    int factor = 1;
    while (num > 0)
    {
        result = result + num % 2 * factor;
        num /= 2;
        factor *= 10;
    }
    return result;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int decToBin = DecimalToBinary(number);
Console.WriteLine(decToBin);