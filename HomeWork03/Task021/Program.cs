// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();
Console.WriteLine("Точка 1 - X:");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Точка 1 - Y:");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Точка 1 - Z:");
double z1 = double.Parse(Console.ReadLine());
Console.WriteLine("Точка 2 - X:");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Точка 2 - Y:");
double y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Точка 2 - Z:");
double z2 = double.Parse(Console.ReadLine());


double D = Math.Sqrt (Math.Pow( x1 - x2, 2) + Math.Pow( y1 - y2, 2) + Math.Pow( z1 - z2, 2));

Console.WriteLine($"Расстояние ваших точек равно {D:f1}");