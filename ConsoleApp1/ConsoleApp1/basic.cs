using System;

public class Class1
{
	static void Main(string[] args)
	{
        
        Console.WriteLine("Enter your name");
        String name = Console.ReadLine();
        Console.WriteLine($"Hello {name}! welcome to C #");
        int i = 0;
        for (i = 0; i <= 10; i++)
        {
            Console.WriteLine($"value of i is {i}");
        }
        if (i == 0)
        {
            Console.WriteLine("inside if");
        }
        else
        {
            Console.WriteLine("inside if");
        }
        i = 0;
        switch (i)
        {
            case 0:
                Console.WriteLine("0");
                break;
            case 1:
                Console.WriteLine("1");
                break;
            default:
                Console.WriteLine("default");
                break;
        }
        String[] names = { "Manish", "deepa", "dipens" };
        String[][] twoD = { ["ram", "manish"], ["deepa", "sandip"] };
        foreach (var item in names)
        {
            Console.WriteLine($"{item}");
        }
        foreach (var item in twoD)
        {
            foreach (var it in item)
            {
                Console.WriteLine($"{it}");
                {

                }
            }
        }

    }
}
