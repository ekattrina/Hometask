class Program
{
    static bool ContainsNumber(int[] arr, int number)
    {
        foreach (int el in arr)
        {
            if (el == number) return true;
        }
        return false;
    }

    static int[] RemoveNumber(int[] arr, int number)
    {
        int count = 0;
        foreach(int el in arr)
        {
            if(el != number)
            {
                count++;
            }
        }

        int[] newArr = new int[count];
        int i = 0;
        foreach(int el in arr)
        {
            if (el != number)
            {
                newArr[i++] = el;
            }
        }

        return newArr;
    }

    static void Main(string[] args) 
    {
        int[] arr = { 1, 2, 17, 5, 6, 7, 8, 87, 14, 1, 2};

        Console.WriteLine("Give a number.");

        if (int.TryParse(Console.ReadLine(), out var number))
        {
            Console.WriteLine(ContainsNumber(arr, number) ? "Contains" : "Does not contain");
            foreach(int el in RemoveNumber(arr, number))
            {
                Console.Write(el + " ");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
