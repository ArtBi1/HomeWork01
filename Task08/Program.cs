// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.Write("Введите число:");
int n = int.Parse(Console.ReadLine());

int b = 2;

if (n > 1)
{
    while (b <= n)
    {
        Console.Write(b+"; ");
        b = b+2;
    }
}
