﻿using System.Globalization;

namespace CSharp_Challenges;

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
    
    public void Beginner1005Average1()
    {
        double a = double.Parse(Console.ReadLine() ?? string.Empty);
        double b = double.Parse(Console.ReadLine() ?? string.Empty);
        double avg = ((a * 3.5) + (b * 7.5)) / 11;
        Console.WriteLine("MEDIA = " + avg.ToString("F5"));
    }
    
    public void Beginner1006Average2()
    {
        double a = double.Parse(Console.ReadLine() ?? string.Empty);
        double b = double.Parse(Console.ReadLine() ?? string.Empty);
        double c = double.Parse(Console.ReadLine() ?? string.Empty);
        double avg = ((a * 2) + (b * 3) + (c * 5)) / 10;
        Console.WriteLine("MEDIA = " + avg.ToString("F1"));
    }
    
    public void Beginner1007Difference()
    {
        int a = int.Parse(Console.ReadLine() ?? string.Empty);
        int b = int.Parse(Console.ReadLine() ?? string.Empty);
        int c = int.Parse(Console.ReadLine() ?? string.Empty);
        int d = int.Parse(Console.ReadLine() ?? string.Empty);
        int diff = (a * b - c * d);
        Console.WriteLine("DIFERENCA = " + diff);
    }
    
    public void Beginner1008Salary()
    {
        int employeeNumber = int.Parse(Console.ReadLine() ?? string.Empty);
        int workedHours = int.Parse(Console.ReadLine() ?? string.Empty);
        double hourlyRate = double.Parse(Console.ReadLine() ?? string.Empty);
        double salary = workedHours * hourlyRate;
        Console.WriteLine("NUMBER = " + employeeNumber);
        Console.WriteLine("SALARY = U$ " + salary.ToString("F2"));
    }
    
    public void Beginner1009SalaryWithBonus()
    {
        string name = Console.ReadLine() ?? string.Empty;
        double salary = double.Parse(Console.ReadLine() ?? string.Empty);
        double sales = double.Parse(Console.ReadLine() ?? string.Empty);
        double total = salary + (sales * 0.15);
        Console.WriteLine("TOTAL = R$ " + total.ToString("F2"));
    }
    
    public void Beginner1010SimpleCalculate()
    {
        string[] product1 = Console.ReadLine()?.Split(' ') ?? Array.Empty<string>();
        string[] product2 = Console.ReadLine()?.Split(' ') ?? Array.Empty<string>();
        int code1 = int.Parse(product1[0]);
        int units1 = int.Parse(product1[1]);
        double price1 = double.Parse(product1[2]);
        int code2 = int.Parse(product2[0]);
        int units2 = int.Parse(product2[1]);
        double price2 = double.Parse(product2[2]);
        double total = (units1 * price1) + (units2 * price2);
        Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2"));
    }
    
    public void Beginner1011Sphere()
    {
        double radius = double.Parse(Console.ReadLine() ?? string.Empty);
        double volume = (4.0 / 3) * 3.14159 * Math.Pow(radius, 3);
        Console.WriteLine("VOLUME = " + volume.ToString("F3"));
    }
    
    public void Beginner1012Area()
    {
        string[] values = Console.ReadLine()?.Split(' ') ?? Array.Empty<string>();
        double a = double.Parse(values[0]);
        double b = double.Parse(values[1]);
        double c = double.Parse(values[2]);
        double triangle = (a * c) / 2;
        double circle = 3.14159 * Math.Pow(c, 2);
        double trapezium = ((a + b) * c) / 2;
        double square = Math.Pow(b, 2);
        double rectangle = a * b;
        Console.WriteLine("TRIANGULO: " + triangle.ToString("F3"));
        Console.WriteLine("CIRCULO: " + circle.ToString("F3"));
        Console.WriteLine("TRAPEZIO: " + trapezium.ToString("F3"));
        Console.WriteLine("QUADRADO: " + square.ToString("F3"));
        Console.WriteLine("RETANGULO: " + rectangle.ToString("F3"));
    }
    
    public void Beginner1013TheGreatest()
    {
        string[] values = Console.ReadLine()?.Split(' ') ?? Array.Empty<string>();
        int a = int.Parse(values[0]);
        int b = int.Parse(values[1]);
        int c = int.Parse(values[2]);
        int ab = (a + b + Math.Abs(a - b)) / 2;
        int abc = (ab + c + Math.Abs(ab - c)) / 2;
        Console.WriteLine(abc + " eh o maior");
    }
    
    public void Beginner1014Consumption()
    {
        int distance = int.Parse(Console.ReadLine() ?? string.Empty);
        double fuel = double.Parse(Console.ReadLine() ?? string.Empty);
        double consumption = distance / fuel;
        Console.WriteLine(consumption.ToString("F3") + " km/l");
    }
    
    public void Beginner1015DistanceBetweenTwoPoints()
    {
        string[] p1 = Console.ReadLine()?.Split(' ') ?? Array.Empty<string>();
        string[] p2 = Console.ReadLine()?.Split(' ') ?? Array.Empty<string>();
        double x1 = double.Parse(p1[0]);
        double y1 = double.Parse(p1[1]);
        double x2 = double.Parse(p2[0]);
        double y2 = double.Parse(p2[1]);
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        Console.WriteLine(distance.ToString("F4"));
    }
    
    public void Beginner1016Distance()
    {
        int distance = int.Parse(Console.ReadLine() ?? string.Empty);
        int time = distance * 2;
        Console.WriteLine(time + " minutos");
    }
    
    public void Beginner1017FuelSpent()
    {
        int time = int.Parse(Console.ReadLine() ?? string.Empty);
        int speed = int.Parse(Console.ReadLine() ?? string.Empty);
        int distance = time * speed;
        double fuel = distance / 12.0;
        Console.WriteLine(fuel.ToString("F3"));
    }
    
    public void Beginner1018Banknotes()
    {
        int n = int.Parse(Console.ReadLine() ?? string.Empty);
        int[] notes = {100, 50, 20, 10, 5, 2, 1};
        Console.WriteLine(n);
        foreach (int note in notes)
        {
            int count = n / note;
            Console.WriteLine(count + " nota(s) de R$ " + note + ",00");
            n %= note;
        }
    }
    
    public void Beginner1019TimeConversion()
    {
        int n = int.Parse(Console.ReadLine() ?? string.Empty);
        int hours = n / 3600;
        int minutes = (n % 3600) / 60;
        int seconds = n % 60;
        Console.WriteLine(hours + ":" + minutes + ":" + seconds);
    }
    
    public void Beginner1020AgeInDays()
    {
        int days = int.Parse(Console.ReadLine() ?? string.Empty);
        int years = days / 365;
        int months = (days % 365) / 30;
        int remainingDays = (days % 365) % 30;
        Console.WriteLine(years + " ano(s)");
        Console.WriteLine(months + " mes(es)");
        Console.WriteLine(remainingDays + " dia(s)");
    }
    
    public void Beginner1021BanknotesAndCoins()
    {
        double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        int centavos = (int)Math.Round(valor * 10 );  
        int[] notas = { 10000, 5000, 2000, 1000, 500, 200 };
        int[] moedas = { 100, 50, 25, 10, 5, 1 };
        Console.WriteLine("NOTAS:");
        foreach (int nota in notas)
        {
            int quantidade = centavos / nota;
            Console.WriteLine($"{quantidade} nota(s) de R$ {(nota / 100.0).ToString("F2", CultureInfo.InvariantCulture)}");
            centavos %= nota;
        }
        Console.WriteLine("MOEDAS:");
        foreach (int moeda in moedas)
        {
            int quantidade = centavos / moeda;
            Console.WriteLine($"{quantidade} moeda(s) de R$ {(moeda / 100.0).ToString("F2", CultureInfo.InvariantCulture)}");
            centavos %= moeda;
        }
    }
        
    public void Beginner1035SelectionTest1()
    {
        string[] values = Console.ReadLine()?.Split(' ') ?? Array.Empty<string>();
        int a = int.Parse(values[0]);
        int b = int.Parse(values[1]);
        int c = int.Parse(values[2]);
        int d = int.Parse(values[3]);
        if (b > c && d > a && c + d > a + b && c > 0 && d > 0 && a % 2 == 0)
        {
            Console.WriteLine("Valores aceitos");
        }
        else
        {
            Console.WriteLine("Valores nao aceitos");
        }
    }
    
    public void Beginner1036BhaskarasFormula()
    {
        string[] values = Console.ReadLine()?.Split(' ') ?? Array.Empty<string>();
        double a = double.Parse(values[0]);
        double b = double.Parse(values[1]);
        double c = double.Parse(values[2]);
        double delta = Math.Pow(b, 2) - 4 * a * c;
        if (delta < 0 || a == 0)
        {
            Console.WriteLine("Impossivel calcular");
        }
        else
        {
            double r1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double r2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("R1 = " + r1.ToString("F5"));
            Console.WriteLine("R2 = " + r2.ToString("F5"));
        }
    }
    
    public void Beginner1037Interval()
    {
        double n = double.Parse(Console.ReadLine() ?? string.Empty);
        if (n < 0 || n > 100)
        {
            Console.WriteLine("Fora de intervalo");
        }
        else if (n <= 25)
        {
            Console.WriteLine("Intervalo [0,25]");
        }
        else if (n <= 50)
        {
            Console.WriteLine("Intervalo (25,50]");
        }
        else if (n <= 75)
        {
            Console.WriteLine("Intervalo (50,75]");
        }
        else
        {
            Console.WriteLine("Intervalo (75,100]");
        }
    }
    
    public void Beginner1038Snack()
    {
        string[] values = Console.ReadLine()?.Split(' ') ?? Array.Empty<string>();
        int code = int.Parse(values[0]);
        int quantity = int.Parse(values[1]);
        double[] prices = {4.0, 4.5, 5.0, 2.0, 1.5};
        double price = prices[code - 1] * quantity;
        Console.WriteLine("Total: R$ " + price.ToString("F2"));
    }
    
}