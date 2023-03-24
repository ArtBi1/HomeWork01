//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.Write("a:");
int a = int.Parse(Console.ReadLine());
Console.Write("b:");
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.WriteLine(a);
}else
{
    Console.WriteLine(b);
}

