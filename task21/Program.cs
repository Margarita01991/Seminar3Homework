// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. A (3,6,8); B (2,1,-7), -> 15.84; A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
Console.WriteLine("введите координаты точки A: введите xa");
double xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите ya");
double ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите za");
double za = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите координаты точки B: введите xb");
double xb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите yb");
double yb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите zb");
double zb = Convert.ToDouble(Console.ReadLine());
double[] arrayA = {xa, ya, za};
double[] arrayB = {xb, yb, zb};
//distance      = √ (x b — x a) 2 + (y b — y a) 2 + (z b — z a)
double distance = Math.Sqrt(Math.Pow(arrayB[0] - arrayA[0], 2) + Math.Pow(arrayB[1] - arrayA[1], 2) + Math.Pow(arrayB[2] - arrayA[2], 2));

Console.WriteLine($"Расстояние между точками равно {distance}");