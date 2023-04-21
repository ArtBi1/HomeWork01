// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.Clear();

Console.WriteLine("Введите количество строк массива:");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int columns = int.Parse(Console.ReadLine());

int[,] array = FillArray(rows, columns, 1, 9); // цифры генерируются в диапазоне от 1 до 9

Console.WriteLine($"Строка с наименьшей суммой - {Numbers(array) + 1}");
Print(array);

int[,] FillArray(int a, int b, int min, int max)
{
    int[,] res = new int[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            res[i, j] = new Random().Next(min, max + 1);
        }

    }
    return res;
}
void Print(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write($"{a[i, j]} ");
    }
        Console.WriteLine();
    }
}
int Numbers (int [,] a)
{
    int b = 0;
    int min = 0;
for (int i = 0; i<a.GetLength(1);i++)
    {
        min = min + a[0,i];
    }

for (int i = 1; i<a.GetLength(0);i++)
    {
        int num = 0; 
 for (int j = 0; j<a.GetLength(1);j++)
        {
            num = num+a[i,j];
        }
        if (min > num)
        {
            min = num;
            b = i;
        }
        }
        return b;
}