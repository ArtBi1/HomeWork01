// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("введите значение b1");
double a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double a2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double b2 = Convert.ToInt32(Console.ReadLine());

double x = (-a2 + a1)/(-b1 + b2);
double y = b2 * x + a2;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");