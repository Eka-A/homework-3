﻿
void Ex_001()
{
    Console.WriteLine ("Введите число x1:");
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("Введите число y1:");
    int y1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("Введите число z1:");
    int z1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("Введите число x2:");
    int x2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("Введите число y2:");
    int y2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("Введите число z2:");
    int z2 = Convert.ToInt32(Console.ReadLine());

    double result = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));

    Console.WriteLine(result);
}

//Ex_001();

void Ex_002()
{
    //Напишите программу, которая принимает на вход число (N) 
    //и выдаёт таблицу кубов чисел от 1 до N.

    Console.WriteLine ("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    int start= 1;
    int finish=number;

        while (start<=finish)
        {
            Console.WriteLine($"{start}*{start}={Math.Pow(start,3)}");
            start++;
        }
}

//Ex_002();

void Ex_003()
{
    //Напишите программу, которая принимает на вход пятизначное число 
    //и проверяет, является ли оно палиндромом.
    
    Console.WriteLine ("Введите пятизначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number > 99999)
    {
        Console.WriteLine ("Значение введено неверно");
    }
    else if (number < 9999)
    {
        Console.WriteLine ("Значение введено неверно");
    }

    string numb = Convert.ToString(number);

    if (numb[0]==numb[4] && numb[1]==numb[3])
    {
        Console.WriteLine ("Дa");
    }

    else if (numb[0]!=numb[4] && numb[1]!=numb[3])
    {
        Console.WriteLine ("Нет");
    }

}

//Ex_003();
