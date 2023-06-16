/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void PrintArray (double[,]matr)
{
    for(int i=0;i<matr.GetLength(0);i++)
    {
        for (int j=0;j<matr.GetLength(1);j++)
        {
            Console.Write(matr[i,j] + " ");
        }
        Console.WriteLine(" ");
    }
}
void FillArray (double[,]matr)
{
    for (int i=0;i<matr.GetLength(0);i++)
    {
        for (int j=0;j<matr.GetLength(1);j++)
        {
            matr[i,j]=Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}


double[,] matrix=new double [3,4];
FillArray(matrix);
PrintArray(matrix);

Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите номер строки:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца:");
int m = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [4,4];
FillArray(matrix);
PrintArray(matrix);

if (n > matrix.GetLength(0) || m > matrix.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {matrix[n,m]}");
}


void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
        {        
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i,j] + " ");
        }   
        Console.WriteLine(); 
    }
}

Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] matrix = new int[5, 4];
FillArray(matrix);

Console.Write("Среднее арифметическое каждого столбца: ");
for (int j = 0; j < matrix.GetLength(1); j++)
{
    double average = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        average = (average + matrix[i, j]);
    }
    average = average / 5;
    Console.Write(average + "; ");
}
Console.WriteLine();
PrintArray(matrix);


void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
*/