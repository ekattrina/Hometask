class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        double operand1 = random.NextDouble() * 100;
        double operand2 = random.NextDouble() * 100;

        Console.WriteLine("Please select an operation: +, -, *, /");
        string sign = Console.ReadLine();

        Console.Write($"{operand1} {sign} {operand2} = ");

        switch (sign)
        {
            case "+":
                Console.WriteLine(operand1 + operand2);
                break;
            case "-":
                Console.WriteLine(operand1 - operand2);
                break;
            case "*":
                Console.WriteLine(operand1 * operand2);
                break;
            case "/":
                Console.WriteLine(operand2 == 0 ? "Division by zero is impossible" : (operand1 / operand2));
                break;
            default:
                Console.WriteLine("Invalid operation. Please select +, -, *, or /.");
                break;
        }
    }
}
