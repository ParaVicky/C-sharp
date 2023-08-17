//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
Console.WriteLine("Введите число");
int day = Convert.ToInt32(Console.ReadLine());

bool Holiday(int day)
{
    if (day > 5)
    {
        return true;
    }
    return false;
}

bool ValidateNumber(int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine("Это не день недели");
    return false;
}
if (ValidateNumber(day))
{
    if (Holiday(day))
    {
        Console.WriteLine("Наконец-то выходной!");
    }
    else
    {
        Console.WriteLine("Пора работать, бездельник!");
    }
}
