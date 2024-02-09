// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.Generic;
namespace MyNameSpace
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            ArrayList array = new ArrayList();
            List<string> list = new List<string>();
            list.Add("manish");//generic type
            list.Add("deepa");
            list.Add("alina");
            array.Add(35);
            array.Add(45);
            array.Add(5);
            Dictionary<String,String> dict = new Dictionary<String,String>();
            dict["name"] = "Manish";
            dict["address"] = "KTM";
            dict["age"] = "50";
            Console.WriteLine($"name of dictionary={dict["name"]}");
            Console.WriteLine($"age of dictionary={dict["age"]}");
            Console.WriteLine($"address of dictionary={dict["addess"]}");
            Console.WriteLine($"array count={array.Count}");
            Console.WriteLine("list name:");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("array items:");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Asynchronous A = new Asynchronous();
          await A.RunTaskAsync();
            PrintData P = new PrintData();
            P.print("string");
            P.print(33);
            P.print(49.3);
            Area a=new Area();
            a.l = 4;
            a.b = 5;
            a.calculate();
            a.display();
            Circle circle = new Circle();
            circle.draw();
            Rect rect = new Rect();
            rect.draw();
            Shape shape = new Shape();
            shape.draw();
          
        }
    }
}
class Asynchronous
{
    public async Task RunTaskAsync()
    {
        Console.WriteLine("Starting asynchronous task...");

        // Simulate some asynchronous work with Task.Delay
        await Task.Delay(2000); // This simulates work that takes 2 seconds

        Console.WriteLine("Asynchronous task completed.");
    }
}
class PrintData
{
    //polymorphism
    public void print(String name)
    {
        Console.WriteLine($"data={name}");
    }
    public void print(int data)
    {
        Console.WriteLine(data);
    }
    public void print(double data)
    {
        Console.WriteLine(data);
    }
}
class Shape
{
    public virtual void draw()
    {
        Console.WriteLine("shape class");
    }
}
class Circle : Shape
{
    public override void draw()
    {
        Console.WriteLine("From circle");
    }
}
class Rect : Shape
{
    public override void draw()
    {
        Console.WriteLine("From Rect");
    }
}
public partial class Area
{
    public int l;
    public int b;
    private double res;
    
    public void calculate()
    {
        this.res = l * b;
    }
}
public partial class Area()
{
    public void display()
    {
        Console.WriteLine($"l={l} and b={b}");
        Console.WriteLine($"area is ={res}");
    }
}