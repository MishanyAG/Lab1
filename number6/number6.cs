class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This program counts the area of a triangle on three sides");
        Console.Write("enter the side AB = ");
        if (int.TryParse(Console.ReadLine(), out int ab) == false)
        {
            Console.WriteLine("Incorrect data entered");
            Environment.Exit(0);
        }
        Console.Write("enter the side CA = ");
        if (int.TryParse(Console.ReadLine(), out int ca) == false)
        {
            Console.WriteLine("Incorrect data entered");
            Environment.Exit(0);
        }
        Console.Write("enter the side BC = ");
        if (int.TryParse(Console.ReadLine(), out int bc) == false)
        {
            Console.WriteLine("Incorrect data entered");
            Environment.Exit(0);
        }
        if ((ab + bc > ca) && (ab + ca > bc) && (bc + ca > ab) && ab>0 && ca>0 && bc>0)
        {
            int p = (ab + bc + ca) / 2;
            var s = Math.Sqrt(p * (p - ab) * (p - bc) * (p - ca));
            Console.WriteLine($"The area of the triangle is equal to {s}");
        }
        else
        {
            Console.WriteLine("Incorrect data entered");
        }
    }
}

