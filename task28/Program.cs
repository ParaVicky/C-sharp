// программа принимает на вход число N и выдает произведение от 1 до N
// 4 -> 24
// 5 -> 120

int Multiplication (int num)
{
    int multiplication = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            multiplication = multiplication * i;
        }
    }
    return multiplication;
}
Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

int multiplication = Multiplication(number);
Console.WriteLine($"Произведение чисел от 1 до {number} -> {multiplication}");