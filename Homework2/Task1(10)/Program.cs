// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();

System.Console.WriteLine("Введите трехзначное число:");
string Enter = System.Console.ReadLine()!;
if (int.TryParse(Enter, out int number) && Enter.Length == 3)
{
    System.Console.WriteLine($"Вторая цифра введенного числа: {Enter[1]}");
}
else
{
    System.Console.WriteLine("Введен текст или некорректное число");
}