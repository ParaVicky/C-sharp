// на вход принимает 3-значное число и на выходе выдает последнюю цифру этого числа
// 456 -> 6
// 782 -> 2
Console.WriteLine("введите 3-значное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number<0) number*=-1;
if (number>=100 && number <=999)
{
    int lastDigit = number%10;
    Console.WriteLine($"Последняя цифра числа {number} -> {lastDigit}");
}
else Console.WriteLine("Введено некорректное число");

