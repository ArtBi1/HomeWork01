// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Clear();

Console.WriteLine("Введите число N:");
int n = int.Parse(Console.ReadLine());

int before = 1;

Console.WriteLine(Print(before, n));

string Print(int go, int end)
{
    if (end == go)
    {
        Console.WriteLine(end);
        return go.ToString();
    }

    string m = Print(go, end - 1) + ' ' + end.ToString();
    Console.WriteLine(m);
    return (m);
}