// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


Console.Clear();
Console.WriteLine("Введите размер массива:");
int a = int.Parse(Console.ReadLine());
int[] MyArray = RandomArray (a, -100, 100);
int sum = 0;
Console.WriteLine(String.Join(" ", MyArray));
Console.WriteLine($"Максимальное число массива {Maximum(MyArray)}, минимальное число {Minimum(MyArray)}, разница между ними = {Maximum(MyArray) - Minimum(MyArray)}");


int[] RandomArray (int size, int minValue, int maxValue)
{
    int[] a = new int[size];
    for (int i = 0; i < size; i++)
    {
        a[i] = new Random().Next(minValue, maxValue + 1);
    }
    return a;
}

int Maximum(int[] array)
{
    int max = int.MinValue;
    if (MyArray.Length != 0)
    {
        foreach (var i in MyArray)
        {
            if (i > max)
            {
                max = i;
            }
        }
    }
    return max;
}

int Minimum(int[] array)
{
    int min = int.MaxValue;
    if (MyArray.Length != 0)
    {
        foreach (var i in MyArray)
        {
            if (i < min)
            {
                min = i;
            }
        }
    }
        return min;
}