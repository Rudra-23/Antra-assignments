using System;
using Strings;

Console.WriteLine("Question 1: ");
string str = "24tvcoi92";
Console.WriteLine("Original str: " + str);
HandlesStrings strings = new HandlesStrings();
strings.ReverseStringMethod1(str);
strings.ReverseStringMethod2(str);

Console.WriteLine("\nQuestion 2: ");
str = "The quick brown fox jumps over the lazy dog /Yes! Really!!!/.";
Console.WriteLine(str);
string ans = strings.ReverseSentence(str);
Console.WriteLine(ans);

Console.WriteLine("\nQuestion 3: ");
str = "Hi,exe? ABBA! Hog fully a string: ExE. Bob";
string[] temp = strings.GetPalindrome(str);
foreach(string t in temp) {
    Console.WriteLine(t);
}

Console.WriteLine("\nQuestion 4: ");
str = "https://www.apple.com/iphone";
temp = strings.ParseURL(str);
Console.WriteLine("Protocol: " + temp[0]);
Console.WriteLine("Server: " + temp[1]);
Console.WriteLine("Resource: " + temp[2]);