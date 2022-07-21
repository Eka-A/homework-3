
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



