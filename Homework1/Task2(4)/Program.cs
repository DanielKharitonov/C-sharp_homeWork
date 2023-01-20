// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();

System.Console.WriteLine("Введите 1-е число: ");
int Number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите 2-е число: ");
int Number2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите 3-е число: ");
int Number3 = Convert.ToInt32(Console.ReadLine());

if (Number1 > Number2 && Number1 > Number3)
{
    System.Console.WriteLine($"Max = {Number1}");
}
else
{
    if (Number2 > Number3)
    {
        System.Console.WriteLine($"Max = {Number2}");
    }
    else
    {
        System.Console.WriteLine($"Max = {Number3}");
    }
}