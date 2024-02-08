// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
     Customer C = new Customer(1, "Deepa", "KTM");
         Console.WriteLine("Default value");
         C.display();

         Console.WriteLine("User value");
        
        Employee E = new Employee(33, "Mandip", "Dharan", 400000);
        E.display();

        Employee E1 = new Employee();
        E1.setData();
        E1.display();
       
        
        College college = new College();
        college.setData("BMC", "Dharan");
        college.displayDetails();
        Today t = new Today();
        t.displayDetails();
        int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
        foreach (var item in arr)
        {
            Console.WriteLine($"array item={item}");
        }
        try
        {
            Console.WriteLine($"item at index 10 is {arr[10]}");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.Write($"Exception has occured:{ex}");
        }
        finally
        {
            Console.WriteLine("Exception handled");
        }
    }
}


class Account
{

    private int id;
    private string name;

    public String gateName()
    {
        return name;
    }
    public int getId()
    {
        return id;
    }
   public Account(int id,String name)
    {
        this.id = id;
        this.name = name;
    }
    public virtual void display() 
    {
        Console.WriteLine($"Name ={name}");
        Console.WriteLine($"id={id}");
    }
    public void setData()
    {
        
            Console.WriteLine("Enetr name");
            name = Console.ReadLine();
            Console.WriteLine("Enetr account id");
            id = int.Parse(Console.ReadLine());
        }

    }
class Customer : Account
{
    private String address;

    public Customer(int id,String name ,String address) : base(id, name) 
    {
        this.address = address;
    }
    public override void display()
    {
        base.display();
        Console.WriteLine($"address={address}");
    }
}

abstract class Person
{
    protected String name;
    protected String address;
    protected int age;
    protected Person(int age,String name,String address)
    {
        this.age = age;
        this.name = name;
        this.address = address;
    }
    protected Person()
    {
        this.age = 0;
        this.name = "";
        this.address = "";
    }
    protected void display()
    {
        Console.WriteLine($"Name={name} \n Address={address}\n age={age}");
    
    }
    protected void setData()
    {
        Console.WriteLine("enter age");
          age=int.Parse(Console.ReadLine());
        Console.WriteLine("Enetr name");
        name=Console.ReadLine();
        Console.WriteLine("Enter address");
        address=Console.ReadLine();


    }
}
class Employee : Person
{
    private double salary;
    public Employee(int age, String name, String address, double salary) : base(age, name, address)
    {
        this.salary = salary;
    }
    public Employee()
    {
        this.salary = 0.0;
    }
    public void display()
    {
        base.display();
        Console.WriteLine($"Salaey={salary}");
    }
    public void setData()
    {
        base.setData();
        Console.WriteLine("Enetr salary");
        salary=int.Parse(Console.ReadLine());
    }
}
sealed class Car
{
    protected String name;
    protected int modelNo;
    public Car(string name, int modelNo)
    {
        this.name = name;
        this.modelNo = modelNo;
    }
    public void displayDetails()
    {
        Console.WriteLine($"name={name} \n model no={modelNo}");
    }
}
//ass Tesla : Car { } //sealded class can not be inherited
struct College
{
    private String name;
    private String address;
    public void setData(String name,String address)
    {
        this.name = name;
        this.address = address;
    }
    public void displayDetails()
    {
        Console.WriteLine($"College name={name} address={address}");
    }
}
enum Days { Sun, Mon, Tues, Wed, Thus, Fri, Sat }
class Today
{
    private int i = 1;
    public void displayDetails()
    {
        switch (i)
        {
            case 1:
                Console.WriteLine($"today is {Days.Sun}");
                break;
            default:
                Console.WriteLine("Invalid");
                break;
        }
    }
}

