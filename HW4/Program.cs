/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B:
Console.Write("Введите число A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int Exponentiation(int numberA, int numberB){
  int result = 1;
  for(int i=1; i <= numberB; i++){
    result = result * numberA;
  }
    return result;
}

int exponentiation = Exponentiation(numberA, numberB);
  Console.WriteLine("Ответ: " + exponentiation);
  
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе:

Console.Write("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumNumber(int numberN)
{

    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
        advance = numberN - numberN % 10;
        result = result + (numberN - advance);
        numberN = numberN / 10;
    }
    return result;
}

int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);

Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран:

void FillArray (int[] collection)
{
    int length=collection.Length;
    int index = 0;
    while (index<length)
    {
        collection[index]=new Random().Next(1,8);
        index++;
    }
}
    void PrintArray(int[]coll)
    {
        int count=coll.Length;
        int position=0;
        Console.Write("[");
        while(position<count)
        {
            Console.Write(coll[position]);
            position++;
             if (position < count){
      Console.Write(", ");
        }
        }
          Console.Write("]");
    }


int []array=new int[8];

FillArray(array);
PrintArray(array);
Console.WriteLine();
*/