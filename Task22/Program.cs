// программа на вход получает число N и выдает таблицу квадратов чисел от 1 до N
// 5 -> 1, 4, 9, 16, 25
// 2 -> 1, 4
Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
void TableOfSquares (int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count, 3} -> {count*count, 5}");
        count++;
    }
}
TableOfSquares(number);
