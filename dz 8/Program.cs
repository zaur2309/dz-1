// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите точку a1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку b1: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку a2: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку b2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку a3: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку b3: ");
int z2 = Convert.ToInt32(Console.ReadLine());
double s= Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine ($"A ({x1},{y1},{z1}); B ({x2},{y2},{z2}) -> {Math.Round(s, 2)}");

