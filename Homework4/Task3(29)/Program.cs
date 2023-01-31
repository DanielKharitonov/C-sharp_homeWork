// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

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
void PrintFillArray(int[] array)
{
   for (int i=0;i<array.Length;i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    System.Console.WriteLine("Массив: [" + string.Join(", ", array) + "]");
}

uint size = EnterNumberNatur("Введите размер массива: ");
Console.Clear();
PrintFillArray(new int[size]);

