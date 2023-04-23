// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();


Console.WriteLine("Введите количество строк массива:");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строчек в столбце массива:");
int str = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int col = int.Parse(Console.ReadLine());


int[,,] Array = new int[num, str, col];
NewArray(Array);
Print(Array);

int inp(string inarray)


{
  Console.Write(inarray);
  int outarray = int.Parse(Console.ReadLine());
  return outarray;
}

void Print (int[,,] Array)
{
  for (int i = 0; i < Array.GetLength(0); i++)
  {
    for (int j = 0; j < Array.GetLength(1); j++)
  {

      for (int n = 0; n < Array.GetLength(2); n++)
    //   Console.Write($"({i})({j}) ");
      {
        Console.Write( $"{Array[i,j,n]}({n},{i},{j}) ");
    
      }
      Console.WriteLine();
  }
  Console.WriteLine();
  }
}

void NewArray(int[,,] Array)
{
  int[] nu = new int[Array.GetLength(0) * Array.GetLength(1) * Array.GetLength(2)];
  int  number;
  for (int i = 0; i < nu.GetLength(0); i++)
  {
    nu[i] = new Random().Next(10, 100);
    number = nu[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (nu[i] == nu[j])
        {
          nu[i] = new Random().Next(10, 100);
          j = 0;
          number = nu[i];
        }
          number = nu[i];
      }
    }
  }
  int count = 0; 
  for (int a = 0; a < Array.GetLength(0); a++)
  {
    for (int b = 0; b < Array.GetLength(1); b++)
    {
      for (int c = 0; c < Array.GetLength(2); c++)
      {
        Array[a, b, c] = nu[count];
        count++;
      }
    }
  }
}