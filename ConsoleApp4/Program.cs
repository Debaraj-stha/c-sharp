﻿using System;

/*using  Mynamespace;
    class Program{
        public static void Main(){
        Console.WriteLine("hello world  ggg ");
         Myclass c=new Myclass();
            c.messag();
        IShape shape=new Circle(5)
           double area = shape.calculateAre();
        Console.WriteLine(area);
        }
    }

public interface IShape
{
    double CalculateArea();
    double CalculatePerimeter();
}

public class Circle : IShape
{
    private double radius ;
    public Curcle(double radius)
    {
        this.radius = radius;
    }
    public double CalculateArea()
    {
        returm Math.PI* radius;
    }
    public double CalculatePerimeter()
    {
        return 2 * Math.PI * radius;
    }
}*/
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
        return  Radius * Radius;
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
