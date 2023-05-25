/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine());

if(a > b){
    Console.WriteLine("max = a");
    Console.WriteLine("min = b");
}
if(a == b){
    Console.WriteLine("a = b");
}
if(b > a){
    Console.WriteLine("max = b");
    Console.WriteLine("min = a");
}

Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

int max = 0;

Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число c");
int c = int.Parse(Console.ReadLine());

if(a > max){
    max = a;
}

if(b > max){
    max = b;
}

if(c > max){
    max = c;
}

Console.WriteLine("max =" + max);

Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

int result = number % 2;

if(result == 0){
    Console.WriteLine("Да");
}
else{
    Console.WriteLine("Нет");
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int evenNumber = 2;

if(number > 1)
{
    while(evenNumber <= number)
    {
        Console.Write(evenNumber + " ");
        evenNumber = evenNumber + 2;
    }
}
*/