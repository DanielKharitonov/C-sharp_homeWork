// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] FillMatrix(uint rows, uint cols)
{
    int[,] matrix = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(0, 100);
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

int[,] SortRowsMatrixMaxMin(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int indexMaxPosition = j;
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, k] > matrix[i, indexMaxPosition]) indexMaxPosition = k;
            }
            int temporary = matrix[i, j];
            matrix[i, j] = matrix[i, indexMaxPosition];
            matrix[i, indexMaxPosition] = temporary;
        }
    }
    return matrix;
}


uint rows = EnterNumberNatur("Введите количество строк матрицы: ");
uint cols = EnterNumberNatur("Введите количество столбцов матрицы: ");
int[,] matrix = FillMatrix(rows, cols);
System.Console.WriteLine();

System.Console.WriteLine("Задана матрица:");
System.Console.WriteLine();
PrintMatrix(matrix);
System.Console.WriteLine();

SortRowsMatrixMaxMin(matrix);
System.Console.WriteLine("Матрица с сортиковкой строк макс. -> мин.:");
System.Console.WriteLine();
PrintMatrix(matrix);
System.Console.WriteLine();

