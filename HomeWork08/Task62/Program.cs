// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

int SideSize = 4; //размер сторон квадратного массива
int[,] Matrix = new int[SideSize, SideSize]; //квадрат

int a = 1;
int i = 0;
int j = 0;

while (a <= Matrix.GetLength(0) * Matrix.GetLength(1))
{
  Matrix[i, j] = a;
  a++;
  if (i <= j + 1 && i + j < Matrix.GetLength(1) - 1) j++;
  
  else if (i < j && i + j >= Matrix.GetLength(0) - 1) i++;

  else if (i >= j && i + j > Matrix.GetLength(1) - 1) j--;

  else i--; }
    


Array(Matrix);
void Array (int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
    {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      if (arr [i,j] / 10 <= 0)
      Console.Write($" {arr[i,j]} ");

      else Console.Write($"{arr[i,j]} ");
    }
    Console.WriteLine();
    }
}