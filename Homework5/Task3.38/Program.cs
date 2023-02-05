// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


Console.Clear();

double[] FillArrayRandomNumbers(uint size, int leftBorder, int rightBorder)
{
    double[] array = new double[size];
    if (leftBorder < rightBorder)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(new Random().Next(leftBorder, rightBorder + 1) + new Random().NextDouble(), 2);
        }
    }
    else
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(new Random().Next(rightBorder, leftBorder + 1) + new Random().NextDouble(), 2);
        }
    }
    return array;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join("|", array) + "]");
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

double DifMaxMinNumbers(double[] array)
{
    double minNumber = 0;
    double maxNumber = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minNumber)
        {
            minNumber = array[i];
        }
        else if (array[i] > maxNumber)
        {
            maxNumber = array[i];
        }
    }
    double difMaxMinNumbers = maxNumber - minNumber;
    return difMaxMinNumbers;
}

uint size = EnterNumberNatur("Введите размер массива:");
int leftBorder = EnterNumber("Введите зачение левой границы интервала чисел для заполнения массива: ");
int rigthBorder = EnterNumber("Введите зачение правой границы интервала чисел для заполнения массива: ");
double[] array = FillArrayRandomNumbers(size, leftBorder, rigthBorder);

Console.Clear();

System.Console.Write("Задан массив вещественных чисел: ");
PrintArray(array);
System.Console.WriteLine($"Разница между макс. и мин. числом массива = {Math.Round(DifMaxMinNumbers(array), 2)}");
