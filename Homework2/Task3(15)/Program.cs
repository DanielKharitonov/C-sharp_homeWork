// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

System.Console.WriteLine("Введите день недели: ");
string enter = Console.ReadLine()!;

if (int.TryParse(enter,out int day) && day > 0 && day < 6)
{
    System.Console.WriteLine("Не выходной день");
}
else if (day == 6 || day == 7)
{
    System.Console.WriteLine("Выходной день");
}
else
{
    System.Console.WriteLine("Введен текст или число, не соответствующее дню недели");
}