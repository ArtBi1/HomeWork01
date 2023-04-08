// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine());

int sum = 0;

while (a > 0)
{
    int num = a % 10;
    a = a / 10;
   sum = sum + num;
}
Console.WriteLine($"Сумма всех чисел равна {sum}");