// Задача 40: Напишите программу, которая принимает на вход три числа и
// проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите число A");
int num_A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int num_B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C");
int num_C = Convert.ToInt32(Console.ReadLine());

bool IsExistTriangle (int side1, int side2, int side3)
{
    if(side1<side2+side3 && side2< side1+side3 && side3<side2+side1) return true;
    else return false;
}
bool result = IsExistTriangle(num_A, num_B, num_C);
Console.WriteLine(result ? "Треугольник существует" : "Треугольника с заданными параметрами не существует");
