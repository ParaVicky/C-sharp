// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int numN = Convert.ToInt32(Console.ReadLine());

int SumOFNaturalNumbers(int numberM, int numberN)
{
    if (numberN ==numberM ) return numberN;
    else return numberM+SumOFNaturalNumbers(numberM+1, numberN);
  
}

Console.WriteLine(SumOFNaturalNumbers(numM, numN));