// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
            matrix[i, j] = new Random().Next(0, 10);
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

void PrintArray(double[] array)
{
    System.Console.WriteLine(string.Join("\t", array));
}

double[] AverageCols(int[,] matrix)
{
    double[] averageCols = new double[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
   
        double sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum=sum+matrix[j,i];
        }
        averageCols[i]=Math.Round(sum/matrix.GetLength(1),1);
    }
return averageCols;
}

uint rows = EnterNumberNatur("Введите количество строк матрицы: ");
uint cols = EnterNumberNatur("Введите количество столбцов матрицы: ");
int[,] matrix = FillMatrix(rows, cols);
System.Console.WriteLine();

System.Console.WriteLine("Задан массив:");
System.Console.WriteLine();
PrintMatrix(matrix);
System.Console.WriteLine();

double [] averageCols = AverageCols(matrix);
System.Console.WriteLine("Среднее арфетическое столбцов массива:");
System.Console.WriteLine();
PrintArray(averageCols);



