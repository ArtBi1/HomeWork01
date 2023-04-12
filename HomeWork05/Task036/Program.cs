// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Clear();

int[] nums = new int[10];
RandomNumbers(nums);
Console.WriteLine("Одномерный массив, заполненный случайными числами: ");
Print(nums);
int sum = 0;
for (int i = 0; i < nums.Length; i+=2)
        sum = sum + nums[i];
        Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях равна {sum}");

void RandomNumbers(int[] nums)
{
    for(int i = 0; i < nums.Length; i++ )
    
        nums[i] = new Random().Next(-100,100); // Здесь можно задать нужный промежуток, среди которого будут генерироваться рандомные числа
        }
    
void Print(int[] nums)
{
    for(int i = 0; i < nums.Length; i++)
    {
        Console.Write(nums[i] + " ");
    }
             Console.WriteLine();
}