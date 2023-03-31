// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


Console.Clear();
Console.WriteLine("Введите число N:");
int N = int.Parse(Console.ReadLine());
int[] result = new int[N];

for (int i = 1; i <= N; i++)
result[i - 1] = i * i * i;

for (int i = 0; i < N; i++)
Console.Write($" {result [i] } ");