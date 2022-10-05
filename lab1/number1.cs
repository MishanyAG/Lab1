using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This program calculates the area of a rectangle on two sides");
        Console.Write("enter the side A = ");
        if (int.TryParse(Console.ReadLine(), out int a) == false)
        {
            Console.WriteLine("Incorrect data entered");
            Environment.Exit(0);
        }
        Console.Write("enter the side B = ");
        if (int.TryParse(Console.ReadLine(), out int b) == false)
        {
            Console.WriteLine("Incorrect data entered");
            Environment.Exit(0);
        }
        if (a > 0 && b > 0)
        {
            Console.Write($"The area of a given rectangle is equal to {a * b}");
        }
        else
            Console.Write("Incorrect data entered");
    }
}

