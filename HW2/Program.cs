/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1

Console.WriteLine("Введите чило: ");
int number = int.Parse(Console.ReadLine());
if (number < 100 | number > 999)
{
    Console.WriteLine("Введено некорректное число");
    return;
}
double i = number / 10;
double result = i % 10;

Console.WriteLine(result);
*/

/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);
if (numberText.Length > 2)
{
    Console.WriteLine(numberText[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
*/

/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number < 1 | number > 7)
{
    Console.WriteLine("Это не день недели");
}

if (number == 1)
{
    Console.WriteLine("Понедельник");
}

if (number == 2)
{
    Console.WriteLine("Вторник");
}

if (number == 3)
{
    Console.WriteLine("Среда");
}

if (number == 4)
{
    Console.WriteLine("Четверг");
}

if (number == 5)
{
    Console.WriteLine("Пятница");
}

if (number == 6)
{
    Console.WriteLine("Суббота");
}

if (number == 7)
{
    Console.WriteLine("Воскресенье");
}

if (number == 6 | number == 7)
{
    Console.WriteLine("Выходной");
}
*/