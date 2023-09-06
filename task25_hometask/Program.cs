// Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Алгоритм нужно реализовать самостоятельно, встроенную функцию использовать нельзя.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int numberB = Convert.ToInt32(Console.ReadLine());

int Exponentation(int num)
{
    int exp = 1;
    for (int i = 1; i <= numberB; i++)
    {
        exp = exp*numberA;
    }
    return exp;
}


int result = Exponentation(numberA);
Console.WriteLine(Exponentation(numberA));


