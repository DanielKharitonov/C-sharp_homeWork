// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Clear();

string ExitPressEnterOrEsc()
{
    string press = "";
    ConsoleKeyInfo clik;
    do
    {
        clik = Console.ReadKey();
        if (clik.Key == ConsoleKey.Enter)
        {
            press = "Enter";
        }
        else if (clik.Key == ConsoleKey.Escape)
        {
            press = "Escape";
        }
        else
        {
            Console.CursorLeft--;
            System.Console.WriteLine("Нажмите Enter/Esc");
            Thread.Sleep(1000);
            Console.CursorTop--;
            System.Console.WriteLine("                 ");
            Console.CursorTop--;
        }

    } while (clik.Key != ConsoleKey.Enter && clik.Key != ConsoleKey.Escape);
    return press;
}

double EnterNumber(string messeng)
{
    double number;
    Console.Write(messeng);
    while (true)
    {
        if (!(double.TryParse(Console.ReadLine(), out number)))
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

int NumPositiveNumbers()
{
string press;
int numPositiveNumbers = 0;
do
{
    Console.WriteLine("Опредление количества положительных чисел, введенных пользователем.");
    System.Console.WriteLine();
    Console.WriteLine("Для ввода чисел нажмите Enter. Для завершения программы нажмите Escape.");
    Console.WriteLine("");
    press = ExitPressEnterOrEsc();

    for (int i = 1; press == "Enter"; i++)
    {
        double j = EnterNumber($"{i}-е число: ");
        if (j > 0)
        {
            numPositiveNumbers = numPositiveNumbers + 1;
        }
        press = ExitPressEnterOrEsc();
    }
} while (press != "Escape");
return numPositiveNumbers;
}


int n =NumPositiveNumbers();

Console.Clear();
System.Console.WriteLine($"Введено положительных чисел: {n}");
