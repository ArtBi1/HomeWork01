// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

Console.WriteLine("Введите количество строк первой матрицы:");
int row1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы:");
int col1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество строк второй матрицы:");
int row2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второй матрицы:");
int col2 = int.Parse(Console.ReadLine());

if (col1 != row2)
{
    Console.WriteLine("Умножение невозможно");
    return ;
}
// else Console.WriteLine("Умножение возможно");

 // Ввод элементов
int[,] one = Array(row1, col1, 0, 9); //цифры в первом массиве от 0 до 9
int[,] two = Array(row2, col2, 1, 9); //цифры во втором массиве от 1 до 9
Console.WriteLine("Первый массив:");
Print(one);
Console.WriteLine();
Console.WriteLine("Второй массив:");
Print(two);
Console.WriteLine();
Console.WriteLine("Произведение двух матриц:");
Print(MatrixMultiplication(one,two));

int[,] Array(int a, int b, int min, int max)
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
void Print(int[,] go)
{
    for (int i = 0; i < go.GetLength(0); i++)
    {
        for (int j = 0; j < go.GetLength(1); j++)
        {
            Console.Write($"{go[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] MatrixMultiplication(int[,] ArrOne, int[,] ArrTwo)
    {   
    int[,] Arr = new int [ArrOne.GetLength(0),ArrTwo.GetLength(1)];
    for (int i = 0; i < ArrOne.GetLength(0); i++)
   {
    for (int j = 0; j < ArrTwo.GetLength(1); j++)
    {
        for (int n = 0; n < ArrOne.GetLength(1); n++)
        {
            Arr[i, j] += ArrOne[i, n] * ArrTwo[n, j];
        }
    }
    } 
  return Arr;
  }