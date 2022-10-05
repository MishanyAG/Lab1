class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This program builds a pyramids of stars");
        Console.Write("Enter the number of pyramids ");
        if (int.TryParse(Console.ReadLine(), out int a) == false)
        {
            Console.WriteLine("Incorrect data entered");
            Environment.Exit(0);
        }
        for (int i = 1; i <= a; i++)
        {
            for (int j = 0; j < i; j++)
            {
                string stars = new String('*', j);
                Console.WriteLine(stars.PadLeft(a) + "*" + stars);
            }
        }

    }
}