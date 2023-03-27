// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// От себя - еще предложил представиться


Console.Clear();
Console.WriteLine("Здравстсвуйте, представьтесь");
string username = Console.ReadLine();
Console.WriteLine($"{username}, у каждого дня есть свой номер!");
Console.WriteLine($"1 - Понедельник");
Console.WriteLine($"2 - Вторник");
Console.WriteLine($"3 - Среда");
Console.WriteLine($"4 - Четверг");
Console.WriteLine($"5 - Пятница");
Console.WriteLine($"6 - Суббота");
Console.WriteLine($"7 - Воскресенье");
Console.WriteLine($"Введи номер дня, чтобы узнать, выходной он или нет:");
int n = int.Parse(Console.ReadLine());

while(n < 1 || n > 7)
{
    Console.WriteLine($"{username},будь внимательнее!Такого дня нет!");
    Console.WriteLine("1-Понедельник, 2-Вторник, 3-Среда, 4-Четверг, 5-Пятница, 6-Суббота, 7-Воскресенье");
    Console.WriteLine("Попробуй ввести еще раз:");
    n = int.Parse(Console.ReadLine());
}

if ((n > 0 || n <= 7) && ( n <= 5 ))
{
    Console.WriteLine($"{username},это будний день");
}
else{ 
    Console.WriteLine($"{username},это выходной день!");
}