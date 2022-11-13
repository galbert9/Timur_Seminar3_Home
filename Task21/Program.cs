// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координату x точки а");
int ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y точки а");
int ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z точки а");
int az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату x точки b");
int bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y точки b");
int by = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z точки b");
int bz = Convert.ToInt32(Console.ReadLine());

// Находим проекцию на плоскости ху 
double S1 = Math.Sqrt(Math.Pow((by - ay), 2) + Math.Pow((ax - bx), 2));
Console.WriteLine($"{S1}");

// смещение по оси z = bz - az
double S = Math.Sqrt(Math.Pow(S1, 2) + Math.Pow((az - bz), 2));
Console.WriteLine($"{S}");
