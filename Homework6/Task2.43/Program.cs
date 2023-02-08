// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

double EnterNumber(string messeng)
{
    double number;
    Console.Write(messeng);
    while (true)
    {
        if (!(double.TryParse(Console.ReadLine(), out number)))
        {
            System.Console.WriteLine("Введено некорректное число, попробуйте еще раз.");
            Thread.Sleep(1000);
            Console.CursorTop--;
            System.Console.WriteLine("                                               ");
            Console.CursorTop--;
            Console.CursorTop--;
            System.Console.WriteLine("                                               ");
            Console.CursorTop--;
            Console.Write(messeng);
        }
        else
        {
            break;
        }
    }
    return number;

}

void Equation()
{
System.Console.WriteLine("Нахождение неизвестных Х и Y в уравнениях:");
System.Console.WriteLine("y = k1 * x + b1");
System.Console.WriteLine("y = k2 * x + b2;");
System.Console.WriteLine();

System.Console.WriteLine("Для нахождения неизвестных введите значения переменных:");
double k1 = EnterNumber("k1= ");
double b1 = EnterNumber("b1= ");
double k2 = EnterNumber("k2= ");
double b2 = EnterNumber("b2= ");
System.Console.WriteLine();

double x=(b2-b1)/(k1-k2);
double y=k1*x+b1;

System.Console.WriteLine("Решение уравнений:");
System.Console.WriteLine($"X = {x}, Y ={y}");
}

Equation();