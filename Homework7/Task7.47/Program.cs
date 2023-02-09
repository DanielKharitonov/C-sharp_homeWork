// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

uint EnterNumber(string messeng)

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

double[,] FillMatrix(uint rows, uint cols)
{
    double[,] matrix = new double[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = Math.Round(new Random().Next(0, 100) + new Random().NextDouble(), 2);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
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

uint m = EnterNumber("Введите количество строк матрицы: ");
uint n = EnterNumber("Введите количество столбцов матрицы: ");
double[,] matrix = FillMatrix(m, n);
System.Console.WriteLine();

PrintMatrix(matrix);