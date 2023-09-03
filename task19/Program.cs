// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да



bool IsPalindrome(int number)
{
    int dig1 = number / 10000;
    int dig2 = (number % 10000) / 1000;
    int dig4 = (number % 100) / 10;
    int dig5 = number % 10;

    return (dig1 == dig5 && dig2 == dig4);
}

bool CheckNumber(int number)
{
    if (number >= 0 && number <= 99999)
    {
        return true;
    }
    else
    {
        Console.WriteLine("Вы ввели некорректное число");
        return false;
    }
}

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
bool checkNumber = CheckNumber(number);
bool isPalindrome = IsPalindrome(number);

Console.WriteLine(isPalindrome ? "Ваше число является палиндромом" : "Ваше число не является палиндромом");
