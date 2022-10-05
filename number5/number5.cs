class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This program displays the sum of all numbers less than 1000, multiples of 3, or 5.");
        int sum = 0;
        for (int i =1;i < 1000; i++)
        {
            if (i % 5 == 0 && i % 3 == 0)
            {
                sum += i;
                
            }
        }
        Console.Write($"Our sum :{sum}");



    }
}
