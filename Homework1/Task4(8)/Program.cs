// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();

System.Console.WriteLine("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());

for(int Numbers=2; Numbers<=Number; Numbers +=2)
{
    System.Console.Write($"{Numbers} ");
}