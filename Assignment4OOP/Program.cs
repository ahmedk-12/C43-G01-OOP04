
internal class Program
{
    static void Main(string[] args)
    {
        #region Q1) Write a class named Calculator that contains a method named Add. Overload the Add method 
        Calculator calc = new Calculator();
        Console.WriteLine("Add(2, 3): " + calc.Add(2, 3));
        Console.WriteLine("Add(2, 3, 4): " + calc.Add(2, 3, 4));
        Console.WriteLine("Add(2.5, 3.5): " + calc.Add(2.5, 3.5));
        #endregion
        #region Q2) Create a class named Rectangle with the following constructors:
        Rectangle rect1 = new Rectangle();
        Rectangle rect2 = new Rectangle(5, 10);
        Rectangle rect3 = new Rectangle(7);
        Console.WriteLine($"rect1: Width={rect1.Width}, Height={rect1.Height}");
        Console.WriteLine($"rect2: Width={rect2.Width}, Height={rect2.Height}");
        Console.WriteLine($"rect3: Width={rect3.Width}, Height={rect3.Height}");
        #endregion
        #region Q3) Define a class Complex Number that represents a complex number with real and imaginary parts.
        ComplexNumber c1 = new ComplexNumber(2, 3);
        ComplexNumber c2 = new ComplexNumber(4, 5);
        ComplexNumber sum = c1 + c2;
        ComplexNumber diff = c1 - c2;
        Console.WriteLine($"c1: {c1.Real} + {c1.Imaginary}i");
        Console.WriteLine($"c2: {c2.Real} + {c2.Imaginary}i");
        Console.WriteLine($"Sum: {sum.Real} + {sum.Imaginary}i");
        Console.WriteLine($"Difference: {diff.Real} + {diff.Imaginary}i");
        #endregion
        #region a) Create a base class named Employee with method That Work as it prints    "Employee is  working".
        Employee emp = new Employee();
        Manager mgr = new Manager();
        emp.Work();
        mgr.Work();
        #endregion
        #region Part02
        Duration d1 = new Duration(1, 10, 15);
        Console.WriteLine(d1.ToString());

        Duration d2 = new Duration(3600);
        Console.WriteLine(d2.ToString());

        Duration d3 = new Duration(7800);
        Console.WriteLine(d3.ToString());

        Duration d4 = new Duration(666);
        Console.WriteLine(d4.ToString());

        Duration sumDuration = d1 + d2;
        Console.WriteLine("Sum Duration: " + sumDuration);
        #endregion
    }
}

#region Q1) Write a class named Calculator that contains a method named Add. Overload the Add method 
public class Calculator
{
    public int Add(int a, int b) => a + b;
    public int Add(int a, int b, int c) => a + b + c;
    public double Add(double a, double b) => a + b;
}
#endregion
#region Q2) Create a class named Rectangle with the following constructors:
public class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }
    public Rectangle() { Width = 0; Height = 0; }
    public Rectangle(int width, int height) { Width = width; Height = height; }
    public Rectangle(int size) { Width = size; Height = size; }
}
#endregion
#region Q3) Define a class Complex Number that represents a complex number with real and imaginary parts.
public class ComplexNumber
{
    public double Real { get; set; }
    public double Imaginary { get; set; }
    public ComplexNumber(double real, double imaginary) { Real = real; Imaginary = imaginary; }
    public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2) => new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
    public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2) => new ComplexNumber(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
}
#endregion
#region Question 4) a) Create a base class named Employee with method That Work as it prints    "Employee is  working".,,,,,,b) Create a derived class named Manager that overrides the Work method to print "Manager is managing". 

public class Employee
{
    public virtual void Work() => Console.WriteLine("Employee is working");
}

public class Manager : Employee
{
    public override void Work()
    {
        base.Work();
        Console.WriteLine("Manager is managing");
    }
}
#endregion
#region 1-Define Class Duration To include Three Attributes Hours, Minutes and Seconds.
public class Duration
{
    public int Hours { get; set; }
    public int Minutes { get; set; }
    public int Seconds { get; set; }

    public Duration(int hours, int minutes, int seconds)
    {
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }
    
    public Duration(int totalSeconds)
    {
        Hours = totalSeconds / 3600;
        Minutes = (totalSeconds % 3600) / 60;
        Seconds = totalSeconds % 60;
    }
    #endregion
    #region 2-Override All System. Object Members [To String(), Equals(),GetHashCode() ] .
    public override string ToString() => $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
    #endregion
    public static Duration operator +(Duration d1, Duration d2)
    {
        int totalSeconds = (d1.Hours + d2.Hours) * 3600 + (d1.Minutes + d2.Minutes) * 60 + (d1.Seconds + d2.Seconds);
        return new Duration(totalSeconds);
    }
}
