class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This program builds a triangle from asterisks");
        Console.Write("Enter the height of the triangle ");
        if (int.TryParse(Console.ReadLine(), out int a) == false){
            Console.WriteLine("Incorrect data entered");
            Environment.Exit(0);
        }
        for(int i = 1; i <= a; i++)
        {
            for (int j = 0; j < i; j++)
                Console.Write("*");
            Console.Write("\n");
        }
       
    }
}