using System;

namespace ConsoleApp1;

public class Program
{
    public static int[] GenerateNumbers()
    {
        Console.WriteLine("Enter the number of elements to store in the array: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 0; i < n; i++) {
            Console.Write($"Enter element {i}: ");
            int x = Convert.ToInt32(Console.ReadLine()); 
            arr[i] = x;
        }

        return arr;
    }

    public static void Reverse(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n / 2; i++)
        {
            int temp = arr[i];
            arr[i] = arr[n - 1 - i];
            arr[n - 1 - i] = temp;
        }
    }

    public static void PrintNumbers(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            if (i != 0) Console.Write(" ");
            Console.Write(arr[i]);
        }
        Console.WriteLine();
    }

    public static int Fibonacci(int n)
    {
        if(n == 0) return 0;

        int first = 1;
        int second = 1;
        if (n <= 2) return 1;

        for (int i = 3; i <= n; i++) {
            int curr = first + second;
            first = second;
            second = curr;
        }
        return second;
    }
    static void Main(string[] args)
    {
        /* Question 1 : Reverse Number */

        int[] numbers = GenerateNumbers();
        Reverse(numbers);
        PrintNumbers(numbers);

        /* Question 2: Fibonacci */
        Console.WriteLine($"The 8th fibonacci number is: " + Fibonacci(8));

        Console.WriteLine("First 10 fibonacci terms");
        for (int i = 1; i <= 10; i++)
        {
            if(i != 1) Console.Write(" ");
            Console.Write(Fibonacci(i));
        }
    }
}

