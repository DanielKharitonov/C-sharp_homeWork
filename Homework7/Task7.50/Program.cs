// Задача 50. Напишите программу, которая на вход принимает число, возвращает индексы этого элемента в двумерном массиве или же указание, что такого числа нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();

int EnterNumber(string messeng)

{
    int number;
    Console.Write(messeng);
    while (true)
    {
        if (!(int.TryParse(Console.ReadLine(), out number)))
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

int[,] FillMatrix(uint rows, uint cols)
{
    int[,] matrix = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(-9, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void SearchNumber(int[,] matrix, int number)
{
    int no = 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == number)
            {
                System.Console.WriteLine($"Индекс числа в массиве ({i},{j})");
                no = 0;
            }
        }
    }
    if (no == 1)
    {
        System.Console.WriteLine($"Числа {number} нет в массиве");
    }
}

uint rows = EnterNumberNatur("Введите количество строк матрицы: ");
uint cols = EnterNumberNatur("Введите количество столбцов матрицы: ");
int enterNumber = EnterNumber("Введите целое однозначное число: ");
int[,] matrix = FillMatrix(rows, cols);
System.Console.WriteLine();
System.Console.WriteLine("Задан массив:");
System.Console.WriteLine();
PrintMatrix(matrix);
System.Console.WriteLine();
SearchNumber(matrix, enterNumber);
