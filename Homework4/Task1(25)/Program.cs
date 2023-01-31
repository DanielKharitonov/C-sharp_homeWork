// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

double EnterNumber(string message)
{
    double number;
    while (true)
    {
        System.Console.Write(message);
        if (!(double.TryParse(Console.ReadLine(), out number)))
        {
            System.Console.WriteLine("Введено некорректное число, попробуйте еще раз.");
        }
        else
        {
            break;
        }
    }
    return number;
}
uint EnterNumberNatur(string message)
{
    uint number;
    while (true)
    {
        System.Console.Write(message);
        if (!(uint.TryParse(Console.ReadLine(), out number)))
        {
            System.Console.WriteLine("Введено некорректное число, попробуйте еще раз.");
        }
        else
        {
            break;
        }
    }
    return number;
}
double NumberToPower(double A, uint B)
{
    double numberToPower = 1;
    for (uint i = 0; i < B; i++)
    {
        numberToPower = numberToPower * A;
    }
    return numberToPower;
}

double A = EnterNumber("Введите число A: ");
uint B = EnterNumberNatur("Введите натуральное число B:");
Console.Clear();
System.Console.WriteLine($"Число {A} в степени {B} = {NumberToPower(A, B)}");