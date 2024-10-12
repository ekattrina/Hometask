class Program
{
    static bool ContainsNumber(int[] arr, int number)  // Task 0
    {
        foreach (int el in arr)
        {
            if (el == number)
            {
                return true;
            }
        }
        return false;
    }

    static int[] RemoveNumber(int[] arr, int number)  // Task 1
    {
        int count = 0;
        foreach (int el in arr)
        {
            if (el != number)
            {
                count++;
            }
        }

        int[] newArr = new int[count];
        int i = 0;
        foreach (int el in arr)
        {
            if (el != number)
            {
                newArr[i++] = el;
            }
        }

        return newArr;
    }

    static int[] GenerateArray(int size) // Task 2
    {
        int[] arr = new int[size];
        Random random = new Random();

        for (int i = 0; i < size; i++)
        {
            arr[i] = random.Next(0, 100);
        }
        return arr;
    }

    static int FindMax(int[] arr) // Task 2
    {
        int max = arr[0];
        foreach (int el in arr)
        {
            if (el > max) max = el;
        }
        return max;
    }

    static int FindMin(int[] arr) // Task 2
    {
        int min = arr[0];
        foreach (int el in arr)
        {
            if (el < min) min = el;
        }

        return min;
    }

    static double FindAverage(int[] arr) // Task 2
    {
        double sum = 0;
        foreach (int el in arr)
        {
            sum += el;
        }

        return (double)sum / arr.Length;
    }

    static void PrintArray(int[] arr)
    {
        foreach (int el in arr)
        {
            Console.Write(el + " ");
        }
        Console.WriteLine();  
    }

    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 17, 5, 6, 7, 8, 87, 14, 1, 2 };

        Console.WriteLine("Give a number."); 

        if (int.TryParse(Console.ReadLine(), out var number))
        {
            Console.WriteLine(ContainsNumber(arr, number) ? "Contains" : "Does not contain"); 
            PrintArray(arr);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number."); 
        }

        Console.WriteLine("\nEnter array's length"); 
        bool isNumber = int.TryParse(Console.ReadLine(), out var size); 
        if (isNumber)
        {
            Console.WriteLine("Your array: "); 
            int[] arr2 = GenerateArray(size);
            PrintArray(arr2);

            Console.WriteLine("\nMax: " + FindMax(arr2)); 
            Console.WriteLine("Min: " + FindMin(arr2));
            Console.WriteLine("Average: " + FindAverage(arr2));
        }
        else
        {
            Console.WriteLine("Wrong input"); 
        }

        int[] first = GenerateArray(5);
        int[] second = GenerateArray(5);
        PrintArray(first);
        PrintArray(second);
        Console.WriteLine(FindAverage(first) > FindAverage(second) ? "First" :
            (FindAverage(second) > FindAverage(first) ? "Second" : "Equal"));



    }
}
