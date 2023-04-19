// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.WriteLine("Введите количество строк массива:");
int numRows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int numColumns = int.Parse(Console.ReadLine());

int[,] numbers = new int[numRows, numColumns];
RandomNumbers (numbers);

Console.WriteLine("Среднее арефметическое столбцов:");
for (int i = 0; i < numbers.GetLength(1); i++)
{
    double mean = 0;
    for (int j = 0; j < numbers.GetLength(0); j++)
    {
        mean = (mean + numbers[j, i]);
    }
    mean = mean / numRows;
    
    Console.Write(mean + "; ");
}
Console.WriteLine();
Console.WriteLine("В массиве:");
Print(numbers);

void RandomNumbers(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}
void Print(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
       
        Console.WriteLine("");
    }
}
