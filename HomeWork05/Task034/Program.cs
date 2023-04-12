// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine());
int[] nums = new int[size];
RandomNumbers(nums);
Console.WriteLine("Сгенерированный массив: ");
PrintNums(nums);
int count = 0;

for (int i = 0; i < nums.Length; i++)
if (nums[i] % 2 == 0)
count++;



void RandomNumbers(int[] nums)
{
    for(int j = 0; j < nums.Length; j++)
    {
        nums[j] = new Random().Next(100, 1000);
    }
}
void PrintNums(int[] nums)
{
    for(int k = 0; k < nums.Length; k++)
    {
        Console.Write (nums[k]+ " ");
    }
    Console.WriteLine();
}
Console.WriteLine($"Массив состоит из {nums.Length} чисел, из них чётных {count}");