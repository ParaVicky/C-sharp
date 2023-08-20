// на вход принимает число N, на выходе показывает все целые числа от -N до N
// 4 -> -4, -3, -2, -1, 0, 1, 2, 3, 4
Console.WriteLine("введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());
int count = -number;
while (count <= number)
{
    Console.Write($"{count} ,");
    count++;
}