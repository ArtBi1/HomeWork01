// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Введите число, для того, чтобы узнать его третью цифру");
int a = int.Parse(Console.ReadLine());

if (a >= 100 && a <= 999 )

{
    int b = a % 10;
    
    Console.Write($"Третья цифра у числа {a} является цифрой {b}");
    return;
}

if (a >= 1000 && a <= 9999 )
{
  
    int b = a / 10; int c = b % 10;
    
    Console.Write($"Третья цифра у числа {a} является цифрой {c}");
    return;
}

if (a >= 10000 && a <= 99999 )
{
  
    int b = a / 100; int c = b % 10;
    
    Console.Write($"Третья цифра у числа {a} является цифрой {c}");
    return;
}
if (a >= 100000 && a <= 999999 )
{
  
    int b = a / 1000; int c = b % 10;
    
    Console.Write($"Третья цифра у числа {a} является цифрой {c}");
    return;
}
if (a >= 1000000 && a <= 9999999 )
{
  
    int b = a / 10000; int c = b % 10;
    
    Console.Write($"Третья цифра у числа {a} является цифрой {c}");
    return;
}
if (a >= 10000000 && a <= 99999999 )
{
  
    int b = a / 100000; int c = b % 10;
    
    Console.Write($"Третья цифра у числа {a} является цифрой {c}");
    return;
}
if (a >= 100000000 && a <= 999999999 )
{
  
    int b = a / 1000000; int c = b % 10;
    
    Console.Write($"Третья цифра у числа {a} является цифрой {c}");
    return;
}
else{
    Console.WriteLine($"В числе {a} нет третьей цифры");
}


















//     Console.WriteLine($"У числа {a} нет третей цифры!");
//     return;
// }
// while ((a >= 100 && a <= 999))
// {
//     int b = a / 100; int c = b % 20;
//     Console.Write($"Третья цифра у числа {a} является цифрой {c}");
//     return;
// }


