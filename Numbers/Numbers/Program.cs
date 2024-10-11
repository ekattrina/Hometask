class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Give a number");
        bool isNumber = double.TryParse(Console.ReadLine(), out var number);

        if (!isNumber)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        else
        {
            switch (number)
            {
                case double n when (n >= 0 && n <= 14):
                    Console.WriteLine("The number belongs to [0;14]");
                    break;
                case double n when (n >= 15 && n <= 35):
                    Console.WriteLine("The number belongs to [15;35]");
                    break;
                case double n when (n >= 36 && n <= 50):
                    Console.WriteLine("The number belongs to [36;50]");
                    break;
                case double n when (n >= 51 && n <= 100):
                    Console.WriteLine("The number belongs to [51;100]");
                    break;
                default:
                    Console.WriteLine("The number is not within any of the intervals");
                    break;
            }
        }
    }
}
