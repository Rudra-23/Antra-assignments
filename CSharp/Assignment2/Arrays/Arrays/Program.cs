using System;
using ArraysAndStrings;
using static System.Runtime.InteropServices.JavaScript.JSType;

/*
 Arrays
 */

/*Q1. Copy and Print Array  */
Console.WriteLine("\n Question 1");
HandleArrays arrays = new HandleArrays();
arrays.CopyAndPrintArray();

/*Q2. Grocery list */
Console.WriteLine("Grocery List: ");
arrays.GroceryList();

/*Q3. Primes  */
Console.WriteLine("\n Question 3");
int[] primes = HandleArrays.FindPrimesInRange(1, 30);
for (int i = 0; i < primes.Length; i++)
{
    Console.Write(primes[i] + " ");
}

/*Q4. Rotate array */
Console.WriteLine("\n Question 4");

Console.WriteLine("Enter a sequence of numbers separated by spaces:");
string input = Console.ReadLine();
int[] arr = input.Split(' ').Select(int.Parse).ToArray();
Console.WriteLine("Enter value of k: ");
int k = int.Parse(Console.ReadLine());

int[] rotatedArray = arrays.RotateAndSum(arr.Length, arr, k);
for (int i = 0; i < rotatedArray.Length; i++)
{
    Console.Write(rotatedArray[i] + " ");
}

/* Q5. Get Longest subarray */
Console.WriteLine("\n Question 5");
arr = new int[] { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
int[] longestSubarray = arrays.GetLongestSubarray(arr);
for (int i = 0; i < longestSubarray.Length; i++)
{
    Console.Write(longestSubarray[i] + " ");
}

/* Q7. Max frequency */
Console.WriteLine("\n Question 7");
arr = new int[] { 4, 4, 4, 3, 3, 3, 2, 1, 2, 2 };
int mxFreq = arrays.MaxFrequency(arr);
Console.WriteLine("Max frequence element in the array: " + mxFreq);


