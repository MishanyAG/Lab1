class Program
{
    static void Main(string[] args)
    {
        if (byte.TryParse(Console.ReadLine(), out byte a) == false)
        {
            Console.WriteLine("Incorrect data entered");
            Environment.Exit(0);
        }
        if (byte.TryParse(Console.ReadLine(), out byte b) == false)
        {
            Console.WriteLine("Incorrect data entered");
            Environment.Exit(0);
        }

        Console.WriteLine($"Operator & = {a & b}\nOperator | = {a | b}\nOperator ^ = {a ^ b}");
    }
}
