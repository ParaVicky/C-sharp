// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите коэффициент b1");
int factorB1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент k1");
int factorK1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент b2");
int factorB2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент k2");
int factorK2 = Convert.ToInt32(Console.ReadLine());
if (factorB1 == factorB2 || factorK1 == factorK2) Console.WriteLine("Прямые парралельны");
if (factorB1 == factorB2 && factorK1 == factorK2) Console.WriteLine("Прямые совпадают");
// k1*x + b1 = k2*x + b2; 