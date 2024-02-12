// Define the interface
public interface IShape
{
    double CalculateArea();
}

// Implement the interface in a class
public class Circle : IShape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double CalculateArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        IShape shape1 = new Circle(5);
        Console.WriteLine($"Area of Circle: {shape1.CalculateArea()}");

        IShape shape2 = new Rectangle(4, 6);
        Console.WriteLine($"Area of Rectangle: {shape2.CalculateArea()}");
    }
}
