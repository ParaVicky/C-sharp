// на вход принимает число и выдает его квадрат
Console.WriteLine("введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int square = number*number;
Console.WriteLine($"квадрат числа {number} -> {square}");