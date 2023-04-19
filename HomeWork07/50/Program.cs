// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


Console.Clear();

Console.WriteLine("Введите количество строк массива: ");
int userRows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int userColumns = int.Parse(Console.ReadLine());

double[,] RandomArray = new double[userRows,userColumns];

Console.WriteLine("Введите позицию на строке массива: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите позицию на столбце массива: ");
int columns = int.Parse(Console.ReadLine());

void rand (int a, int b)
{
    int i, j;
    Random RandomNums = new Random();
    for (i = 0; i < a; i++)
    {
        Console.WriteLine();
        for (j = 0; j < b; j++)
    {
        RandomArray[i,j] = RandomNums.NextDouble();
        Console.Write($"{RandomArray[i,j]:F2} "); // Console.Write($"{RandomArray[i,j]F:5} "); даст остаток 5 в элементах массива
    }
    Console.WriteLine();
}
}

rand (userRows,userColumns);
if (rows < 1 || columns < 1)
Console.WriteLine("Не правильная позиция строки");
else if (rows <= userRows+1 && columns <= userColumns+1)
Console.Write($"Значение выбранного элемента равно {RandomArray[columns-1,rows-1]:F2} "); // Console.Write($"Значение элемента равно {RandomArray[columns-1,rows-1]:F5} "); даст остаток 5 в значении
else Console.WriteLine("Такого элемента нет в массиве");



