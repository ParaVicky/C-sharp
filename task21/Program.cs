// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите координаты  точки A");
Console.Write("x: ");
int xCoordinate1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int yCoordinate1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int zCoordinate1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты  точки B");
Console.Write("x: ");
int xCoordinate2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int yCoordinate2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int zCoordinate2 = Convert.ToInt32(Console.ReadLine());

double Distance(int x1, int y1, int x2, int y2, int z1, int z2)
{
    int side1 = x1 - x2;
    int side2 = y1 - y2;
    int side3 = z1 - z2;
    double distance = Math.Sqrt(side1 * side1 + side2 * side2 + side3 * side3);
    return distance;
}
double result = Distance(xCoordinate1, yCoordinate1, xCoordinate2, yCoordinate2, zCoordinate1, zCoordinate2);
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.Write(resultRound);