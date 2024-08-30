﻿namespace CSharp_Challenges;

public class Beginner
{
    public void Beginner1000HelloWorld()
    {
        Console.WriteLine("Hello World!");
    }

    public void Beginner1001ExtremelyBasic()
    {
        int a = int.Parse(Console.ReadLine() ?? string.Empty);
        int b = int.Parse(Console.ReadLine() ?? string.Empty);
        int x = a + b;
        Console.WriteLine("X = " + x);
    }
    
    public void Beginner1002AreaOfACircle()
    {
        double n = double.Parse(Console.ReadLine() ?? string.Empty);
        double area = 3.14159 * Math.Pow(n, 2);
        Console.WriteLine("A=" + area.ToString("F4"));
    }
    
    public void Beginner1003SimpleSum()
    {
        int a = int.Parse(Console.ReadLine() ?? string.Empty);
        int b = int.Parse(Console.ReadLine() ?? string.Empty);
        int sum = a + b;
        Console.WriteLine("SOMA = " + sum);
    }
    
    public void Beginner1004SimpleProduct()
    {
        int a = int.Parse(Console.ReadLine() ?? string.Empty);
        int b = int.Parse(Console.ReadLine() ?? string.Empty);
        int prod = a * b;
        Console.WriteLine("PROD = " + prod);
    }
    
}