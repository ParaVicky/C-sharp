// Программа принимает на вход число (A) и выдает сумму чисел от 1 до A 
// 7 -> 28
// 4 -> 10
// 8 -> 36

int SumOfNumbers(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
      sum = sum += i;
    }
    return sum;
}
Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumOfNumbers(number);
Console.WriteLine(SumOfNumbers(number));
