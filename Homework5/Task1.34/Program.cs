// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

int[] FillArrayRandomNumbers(uint size, int leftBorder, int rihtBorder)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftBorder, rihtBorder + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(",", array) + "]");
}

int NumberEvenNumbers(int[] array)
{
    int numberEvenNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            numberEvenNumbers = numberEvenNumbers + 1;
        }
    }
    return numberEvenNumbers;
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

uint size = EnterNumberNatur("Введите размер массива:");
int[] array = FillArrayRandomNumbers(size, 100, 999);
System.Console.Write("Задан массив из положительных трехзначных чисел: ");
PrintArray(array);
System.Console.WriteLine($"Количество четных чисел в массиве: {NumberEvenNumbers(array)}");
