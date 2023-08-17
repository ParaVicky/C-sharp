//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int number = Prompt("Введите трехзначное число >");

bool ValidateNumber(int num)
{
    if (num >= 100 || num < 1000)
    {
        return true;
    }
    else
    {
        Console.WriteLine("Вы ввели не трехзначное число. Повторите ввод");
        return false;
    }
}
if (ValidateNumber(number))

Console.WriteLine($"Введенное число '{number}' ");
int secondRank = number / 10 % 10;
Console.WriteLine($"Вторая цифра '{secondRank}' ");