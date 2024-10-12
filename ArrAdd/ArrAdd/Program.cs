using System;
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

    static int[] GetEvenArr(int[] arr) //task 4
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

    static int[] ModifyArr(int[] arr) //task 5
    {
        for (int i = 1; i < arr.Length; i += 2)
        {
            arr[i] = 0;
        }

        return arr;
    }

    static void BubbleSort<T>(T[] arr) where T : IComparable<T> //task 7
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            bool swapped = false;

            for (int j = 0; j < n - 1 - i; j++)
            {
                if (arr[j].CompareTo(arr[j + 1]) > 0)
                {
                    T temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }

            if (!swapped)
                break;
        }
    }

    static int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB) //task 8
    {
        int rowsA = matrixA.GetLength(0);
        int colsA = matrixA.GetLength(1);
        int rowsB = matrixB.GetLength(0);
        int colsB = matrixB.GetLength(1);

        if (colsA != rowsB)
        {
            throw new InvalidOperationException("Number of columns in the first matrix must equal the number of rows in the second matrix.");
        }

        int[,] result = new int[rowsA, colsB];

        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                for (int k = 0; k < colsA; k++)
                {
                    result[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        return result;
    }

    static int Sum(int[,] arr) //task 9
    {
        int sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                sum += arr[i, j];
            }
        }

        return sum;
    }

    static void Diagonal(int[,] arr) //task 10
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (i == j)
                {
                    Console.Write(arr[i, j] + " ");
                }
            }
        }
        Console.WriteLine();
    }

    static void SortRows(int[,] array) //task 11
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            int[] tempRow = new int[columns];

            for (int j = 0; j < columns; j++)
            {
                tempRow[j] = array[i, j];
            }

            Array.Sort(tempRow);

            for (int j = 0; j < columns; j++)
            {
                array[i, j] = tempRow[j];
            }
        }
    }

    static void PrintArray<T>(T[] arr)
    {
        foreach (var i in arr)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
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
        PrintArray(GetEvenArr(arr)); //task 4
        PrintArray(ModifyArr(arr)); //task 5

        string[] names = ["Jack", "Kate", "Rose", "Dona", "Martha", "Amy"];
        BubbleSort(names);
        PrintArray(names); //task 6, 7

        int[,] a =
        {
            {1, 0, 0, 0 },
            {0, 1, 0, 0 },
            {0, 0, 0, 0 }
        };

        int[,] b =
        {
            {1, 2, 3 },
            {1, 1, 1 },
            {0, 0, 0 },
            {2, 1, 0 }
        };

        PrintMatrix(MultiplyMatrices(a, b));

        Console.WriteLine(Sum(a));

        Diagonal(a);

        SortRows(a);
        PrintMatrix(a);
    }
    
}