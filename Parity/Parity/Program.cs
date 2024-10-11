class Program
{
     static void FirstMethod(int number)
    {
        Console.WriteLine(number % 2 == 0 ? "Even" : "Odd");
    }

    static void SecondMethod(int number)
    {
        Console.WriteLine((number & 1) == 0 ? "Even" : "Odd");
    }
      
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        bool isNumber = int.TryParse(Console.ReadLine(), out var number);

        if (isNumber)
        {
            FirstMethod(number);
            SecondMethod(number);
        }
        else
        {
            Console.WriteLine("Wrong input!");
        }
    }
}
