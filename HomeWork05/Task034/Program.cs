// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
Console.WriteLine("Введите размер массива:");
int a = int.Parse(Console.ReadLine());
int[] startArray = GetArray (a, 100, 1000); // Первой цифрой/переменной размер массива, 2-3 промежуток
Console.WriteLine(String.Join(" ", startArray));
Console.WriteLine($"Количество четных чисел в массиве равно {GetElements(startArray, 100, 1000)}");
int [] GetArray (int size, int minValue, int maxValue) {
    int [] res = new int [size];
    for (int i = 0; i < size; i++) {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
    }
    int GetElements(int [] arr, int minValue, int maxValue) {
        int count = 0;
        foreach (int i in arr)
        {
            if (i % 2 == 0)
            count++;
        }
        return count;
    }