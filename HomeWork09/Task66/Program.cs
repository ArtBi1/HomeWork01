﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.WriteLine("Введите первое число:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"Сумма элементов от {m} до {n} = {Sum(m, n)}");

int Sum(int m, int n)
{
    if (m == n)
        return n;
    return n + Sum(m, n - 1);
}