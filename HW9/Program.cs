/*Задайте значение N. Напишите программу,
которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Clear();
Console.WriteLine ("Введите натуральное число:");
int n = int.Parse(Console.ReadLine());

PrintNumbers(n);

void PrintNumbers(int n)
{

    int number = n - 1;
    if (n < 1)
    {
        return;
    }
    Console.Write($"{n} ");
    PrintNumbers(number);

}

Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

Console.Clear();
Console.WriteLine("Введите два натуральных числа: M и N.");
int m = InputInt("Введите M:");
int n = InputInt("Введите N:");
Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} = {SumNaturalElements(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int SumNaturalElements(int m, int n)
{
    if (m == n)
        return n;
    return n + SumNaturalElements(m, n - 1);
}

Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.

Console.Clear();
Console.WriteLine("Введите два положительных числа: M и N.");
int m = InputInt("Введите M: ");
int n = InputInt("Введите N: ");
Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}
*/
