// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.WriteLine("Введите любое число");
int num = Convert.ToInt32(Console.ReadLine());
int evenNum = 2; // первое четное число
if(num > 1)
{
    while(evenNum <= num)
    {
        Console.Write(evenNum + " ");
        evenNum = evenNum + 2;
    }
}

