/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом:

Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();

void numberCheck(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine("Ваше число является палиндромом.");
  }
  else Console.WriteLine("Ваше число не является палиндромом.");
}

if (number!.Length == 5){
  numberCheck (number);
}
else Console.WriteLine("Введено не правильное число.");

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве:

Console.WriteLine("Введите координаты первой точки: ");
Console.Write("x1 = ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("y1 = ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("z1 = ");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");
Console.Write("x2 = ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("y2 = ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("z2 = ");
int z2 = int.Parse(Console.ReadLine());

double distance = DistanceBetweenTwoPoints(x1,y1,z1,x2,y2,z2);

Console.Write("Расстояние между точками = ");
Console.WriteLine(distance);

double DistanceBetweenTwoPoints(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) +
    Math.Pow((y2 - y1), 2) +
    Math.Pow((z2 - z1), 2));
}

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N:

Console.WriteLine("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void cubeNumber(int[] cube)
{
    int i = 0;
    int length = cube.Length;
    while (i < length)
    {
        cube[i] = Convert.ToInt32(Math.Pow(i, 3));
        i++;
    }
}

void cubeTable(int[] coll)
{
    int table = coll.Length;
    int index = 1;
    while (index < table)
    {
        Console.Write(coll[index] + " ");
        index++;
    }
}

int[] arry = new int[cube + 1];
cubeNumber(arry);
cubeTable(arry);
*/