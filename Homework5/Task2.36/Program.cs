// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.Clear();

int[] FillArrayRandomNumbers(uint size, int leftBorder, int rightBorder)
{
    int[] array = new int[size];
    if (leftBorder < rightBorder)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(leftBorder, rightBorder + 1);
        }
    }
    else
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(rightBorder, leftBorder + 1);
        }
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(",", array) + "]");
}

int EnterNumber(string message)
{
    int number;
    while (true)
    {
        System.Console.Write(message);
        if (!(int.TryParse(Console.ReadLine(), out number)))
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

int SumNumbersEvenPosition(int[] array)
{
    int sumNumbersEvenPosition = 0;
    for (int i = 0; i < array.Length; i = i + 2)
    {
        sumNumbersEvenPosition = sumNumbersEvenPosition + array[i];
    }
    return sumNumbersEvenPosition;
}

uint size = EnterNumberNatur("Введите размер массива:");
int leftBorder = EnterNumber("Введите зачение левой границы интервала чисел для заполнения массива: ");
int rigthBorder = EnterNumber("Введите зачение правой границы интервала чисел для заполнения массива: ");
int[] array = FillArrayRandomNumbers(size, leftBorder, rigthBorder);

Console.Clear();

System.Console.Write("Задан массив: ");
PrintArray(array);
System.Console.WriteLine($"Сумма элементов массива, стоящих на четных позициях = {SumNumbersEvenPosition(array)}");

