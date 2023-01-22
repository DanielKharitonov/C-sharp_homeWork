// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

System.Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number>0)
{
   for (int i = 1; i <= number; i++)
{
    double num = Math.Pow(i,3);
    System.Console.Write($"{num} ");
} 
}
else
{
    System.Console.WriteLine("Введено некорректное число");
}