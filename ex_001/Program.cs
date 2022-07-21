
    void Ex_001()
    {
    //Напишите программу, которая принимает на вход координаты двух точек 
    //и находит расстояние между ними в 3D пространстве.

    Random random=new Random();
    int x1 = random.Next (-10,11);
    int y1 = random.Next (-10,11);
    int x2 = random.Next (-10,11);
    int y2 = random.Next (-10,11);
    int z1 = random.Next (-10,11);
    int z2 = random.Next (-10,11);

    Console.WriteLine($"Точка с кооординатами({x1},{y1},{z1})");
    Console.WriteLine($"Точка с кооординатами({x2},{y2},{z2})");

    double result = Math.Sqrt(Math.Pow(z2-x2-x1,2) + Math.Pow(z1-y2-y1,2));

    Console.WriteLine(result);
    }



