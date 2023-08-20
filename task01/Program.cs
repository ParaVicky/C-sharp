// программа на вход принимает 2 числа и проверяет, является ли первое число квадратом второго
// a=25, b=5 -> да
// a=2, b=10 -> нет
Console.WriteLine("введите число 1");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число 2");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA/numberB == numberB)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("нет");
}
