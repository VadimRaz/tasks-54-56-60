﻿// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double distance3D(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double line = Math.Sqrt(Math.Pow(x1-x2, 2)+ Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2)); 
    return Math.Round (line, 2);
}

System.Console.WriteLine("введите координату x точки A: ");
double x1 = Convert.ToInt32 (Console.ReadLine());
System.Console.WriteLine("введите координату y точки A: ");
double y1 = Convert.ToInt32 (Console.ReadLine());
System.Console.WriteLine("введите координату z точки A: ");
double z1 = Convert.ToInt32 (Console.ReadLine());
System.Console.WriteLine("введите координату x точки B: ");
double x2 = Convert.ToInt32 (Console.ReadLine());
System.Console.WriteLine("введите координату y точки B: ");
double y2 = Convert.ToInt32 (Console.ReadLine());
System.Console.WriteLine("введите координату z точки B: ");
double z2 = Convert.ToInt32 (Console.ReadLine());

System.Console.WriteLine(distance3D (x1,y1,z1,x2,y2,z2));
