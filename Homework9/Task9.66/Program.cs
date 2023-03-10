// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

uint EnterNumberNatur(string messeng)
{
    uint number;
    Console.Write(messeng);
    while (true)
    {
        if (!(uint.TryParse(Console.ReadLine(), out number)))
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

uint SumFromNumToNum(uint numberM, uint numberN)
{
    if (numberM < numberN)
    {
        if (numberM == numberN)
            return numberM;
        return numberM + SumFromNumToNum(numberM + 1, numberN);
    }
    else
    {
        if (numberN == numberM)
            return numberN;
        return numberN + SumFromNumToNum(numberM, numberN + 1);
    }
}

uint M = EnterNumberNatur("Введите натуральное число M: ");
uint N = EnterNumberNatur("Введите натуральное число N: ");
System.Console.WriteLine($"Сумма чисел от M до N включительно = {SumFromNumToNum(M, N)}");