using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public class HandleArrays
    {
        public void CopyAndPrintArray()
        {
            int[] originalArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] copiedArray = new int[originalArray.Length];

            for (int i = 0; i < originalArray.Length; i++)
            {
                copiedArray[i] = originalArray[i];
            }

            Console.WriteLine("Original Array:");
            for (int i = 0; i < originalArray.Length; i++) Console.Write(originalArray[i] + " ");

            Console.WriteLine("\nCopied Array:");
            for (int i = 0; i < copiedArray.Length; i++) Console.Write(copiedArray[i] + " ");
        }

        public static int[] FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primes = new List<int>();

            for (int i = startNum; i <= endNum; i++)
            {
                bool flag = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag && i >= 2)
                {
                    primes.Add(i);
                }
            }

            return primes.ToArray();
        }


        public int[] RotateAndSum(int n, int[] arr, int k)
        {
            int[] output = new int[n];

            for (int i = 0; i < n; i++)
            {
                output[i] = 0;
                for (int j = 1; j <= k; j++)
                {
                    int idx = i - j;
                    if (idx < 0) idx += n;
                    output[i] += arr[idx];
                }
            }

            return output;
        }

        public void GroceryList()
        {
            List<string> items = new List<string>();

            while (true)
            {
                Console.WriteLine("\nCurrent list:");

                foreach (string item in items) Console.WriteLine("- " + item);

                Console.WriteLine("\nEnter command (+ item, - item, or -- to clear) else exit:");
                string input = Console.ReadLine().Trim();

                if (input == "--")
                {
                    items.Clear();
                    Console.WriteLine("List cleared.");
                }
                else if (input.StartsWith("+") && input.Length > 1)
                {
                    string newItem = input.Substring(1).Trim();
                    items.Add(newItem);
                    Console.WriteLine($"Added: {newItem}");
                }
                else if (input.StartsWith("-") && input.Length > 1)
                {
                    string removeItem = input.Substring(1).Trim();
                    if (items.Remove(removeItem))
                    {
                        Console.WriteLine($"Removed: {removeItem}");
                    }
                    else
                    {
                        Console.WriteLine($"Item not found: {removeItem}");
                    }
                }
                else
                {
                    Console.WriteLine("Thank you!");
                    break;
                }
            }
        }

        public int[] GetLongestSubarray(int[] arr)
        {
            int n = arr.Length;

            int element = -1;
            int count = 0;

            int mxCount = 0, mxElement = -1;

            for (int i = 0; i < n; i++)
            {
                if (element != arr[i])
                {
                    element = arr[i];
                    count = 1;
                }
                else count++;

                if (mxCount < count)
                {
                    mxCount = count;
                    mxElement = element;
                }
            }

            int[] output = new int[mxCount];
            for (int i = 0; i < mxCount; i++)
            {
                output[i] = mxElement;
            }

            return output;
        }

        public int MaxFrequency(int[] arr)
        {
            int n = arr.Length;

            Dictionary<int, int> frequencyDict = new Dictionary<int, int>();

            foreach (int num in arr)
            {
                if (frequencyDict.ContainsKey(num))
                    frequencyDict[num]++;
                else
                    frequencyDict[num] = 1;
            }

            int element = -1;
            int mxCount = 0;

            for (int i = 0; i < n; i++)
            {
                if (mxCount < frequencyDict[arr[i]])
                {
                    mxCount = frequencyDict[arr[i]];
                    element = arr[i];
                }
            }

            return element;
        }
    }
}
