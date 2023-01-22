// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

System.Console.Write("Введите число: ");
string enter = System.Console.ReadLine()!;

if (int.TryParse(enter, out int number) && number > 99)
{
    while (number > 999)
    {
        number = number / 10;
    }
    System.Console.WriteLine($"Третья цифра введенного числа: {number % 10}");
}
else
{
    System.Console.WriteLine("Введен текст или некорректное число");
}