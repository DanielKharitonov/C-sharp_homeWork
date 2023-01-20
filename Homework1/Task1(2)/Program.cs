// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();

System.Console.WriteLine("Введите 1-е число: ");
int Number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите 2-е число: ");
int Number2 = Convert.ToInt32(Console.ReadLine());

if (Number1 > Number2)
{
    System.Console.WriteLine($"Max = {Number1}");
    System.Console.WriteLine($"Min = {Number2}");
}
else
{
    System.Console.WriteLine($"Max = {Number2}");
    System.Console.WriteLine($"Min = {Number1}");
}
