﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.Write("Введите трехзначное число:");
int a = int.Parse(Console.ReadLine());

if ((a >= 100 && a <= 999))

{
    int b = a / 10; int c = b % 10;
    
    Console.Write($"Вторая цифра у числа {a} является цифрой {c}");
}

    else{
    Console.Write($"Вы ввели не трехзначное число");
    

}

    