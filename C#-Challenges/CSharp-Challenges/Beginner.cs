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
    
}