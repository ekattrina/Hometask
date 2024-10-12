class Program
{
    static int[] GenerateArray(int size) 
    {
        int[] arr = new int[size];
        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            arr[i] = random.Next(0, 100);
        }

        return arr;
    }

    static int[] GetEvenArr(int[] arr)
    {
        int count = 0;
        foreach (int el in arr)
        {
            if (el % 2 == 0)
            {
                count++;
            }
        }

        int[] evenArr = new int[count];
       foreach (int el in arr)
        {
            if ((el % 2) == 0)
            {
                evenArr[--count] = el;
            }
        }

       return evenArr;
    }

    static void PrintArray(int[] arr)
    {
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        bool correctInput = false;
        int n = 0;
        while (!correctInput)
        {
            Console.WriteLine("Give n within (5; 10] for array size");
            bool isInt = int.TryParse(Console.ReadLine(), out n);
            if (isInt)
            {
                if (n > 5 && n <= 10)
                {
                    correctInput = true;
                }
                else
                {
                    Console.WriteLine("Wrong input!!");
                }
            }
            else
            {
                Console.WriteLine("Wrong input!!");
            }
        }

        int[] arr = GenerateArray(n);
        PrintArray(arr);
        PrintArray(GetEvenArr(arr));
    }
    
}