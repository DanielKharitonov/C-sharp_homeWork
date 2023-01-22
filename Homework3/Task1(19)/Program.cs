// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

System.Console.WriteLine("Введите пятизначное число:");
string enter = System.Console.ReadLine()!;

if (int.TryParse(enter, out int number) && enter.Length == 5)
{
    if (enter[0] == enter[4] && enter[1] == enter[3])
    {
        System.Console.WriteLine("Введеное число - полиндром");
    }
    else
    {
        System.Console.WriteLine("Введеное число - не полиндром");
    }
}
else
{
    System.Console.WriteLine("Введен текст или не пятизначное число");
}