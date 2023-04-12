// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.Clear();
Console.WriteLine("Введите размер массива:");
int a = int.Parse(Console.ReadLine());
int[] MyArray = RandomArray (a, -100, 100); // (размер, диапазон массива, диапазон массива)
int sum = 0;
Console.WriteLine(String.Join(" ", MyArray));
Console.WriteLine($"Сумма нечетных элементов массива равна {SumElements(sum)}");

int[] RandomArray (int size, int minV, int maxV) 
{
    int[] b = new int[size];
    for (int i = 0; i < size; i++) 
    {
        b[i] = new Random().Next(minV, maxV +1);
    }
    return b;
  }

int SumElements (int sum) 
    {
    for (int i = 0; i < MyArray.Length; i++) 
    {
        if (i % 2 == 0)
    
        {
            sum += MyArray[i];
        }
    }
    return sum;
}