//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.Write("Введите первое число:");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число:");
int b = int.Parse(Console.ReadLine());

int max = a;
int min = b;
if ( a > max ) max = a;
if ( b > max ) max = b;
if ( a < max ) min = a;
if ( b < max ) min = b;
    Console.Write("Максимальное число = ");
    Console.WriteLine(max);
    Console.Write("Минимальное число = ");
    Console.WriteLine(min);