class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This program builds a pyramid of stars");
        Console.Write("Enter the height of the pyramid ");
        if (int.TryParse(Console.ReadLine(), out int a) == false)
        {
            Console.WriteLine("Incorrect data entered");
            Environment.Exit(0);
        }
        if (a <= 0)
        {
            Console.WriteLine("Incorrect data entered");
            Environment.Exit(0);
        }
        int size = (a*2)-1;
        if (size % 2 == 0)
        {
            size++;
        }
        for (int i = 0; i < size; i += 2)
        {
            for (int j = 0; j < (size - 1) / 2 - (i / 2); j++)
                Console.Write(' ');
            for (int j = 0; j < i + 1; j++)
                Console.Write('*');
            Console.WriteLine();
        }
    }
}