// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

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
int SumNumbersNumber(string number)
{
    int Sum = 0;
    for (int i = 0; i < number.Length; i++)
    {
        Sum = Sum + Convert.ToInt32(Convert.ToString(number[i]));
    }
    return Sum;
}

string A = Convert.ToString(EnterNumberNatur("Введите натуральное число: "));
Console.Clear();
System.Console.WriteLine($"Сумма цифр числа {A} = {SumNumbersNumber(A)}");